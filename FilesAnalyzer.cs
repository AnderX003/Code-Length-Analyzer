using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeLengthAnalyze
{
    public readonly struct FilesAnalyzer
    {
        private const int bufferSize = 1024;
        private const int scriptsStartCount = 40;

        private readonly string[] directories;
        private readonly string[] formats;
        private readonly List<ScriptData> scriptsData = new(scriptsStartCount);
        private readonly char[] buffer = new char[bufferSize];

        public FilesAnalyzer(string[] directories, string[] formats)
        {
            this.directories = directories;
            this.formats = formats;
        }

        public List<ScriptData> Analyze(out bool result)
        {
            result = false;
            foreach (var path in directories)
            foreach (var format in formats)
                result |= TrySearchByExtension(path, format);

            return result ? scriptsData : null;
        }

        private bool TrySearchByExtension(string rootPath, string extension)
        {
            string[] files;
            try
            {
                files = Directory.GetFiles
                (
                    rootPath,
                    $"*{extension}",
                    SearchOption.AllDirectories
                );
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occured:\n{e.Message}");
                return false;
            }

            if (files.Length == 0) return false;
            foreach (var file in files) AnalyzeFile(file);
            return true;
        }

        private void AnalyzeFile(string path)
        {
            var fileParams = new ScriptData
            {
                FullDirectory = path,
                FileName = Path.GetFileName(path)
            };

            var fin = File.OpenText(path);
            var hasNonWhiteSpaceChar = false;
            int readLen;
            do
            {
                readLen = fin.ReadBlock(buffer, 0, bufferSize);
                for (int i = 0; i < readLen; i++)
                {
                    var c = buffer[i];
                    if (c == ';')
                        fileParams.DotComaCount++;
                    if (c == '\n')
                    {
                        fileParams.LinesOfCode++;
                        if (hasNonWhiteSpaceChar)
                            hasNonWhiteSpaceChar = false;
                        else
                            fileParams.EmptyStrings++;
                    }
                    else if (c != ' ' && c != '\t' && c != '\r')
                        hasNonWhiteSpaceChar = true;
                }
            } while (readLen == bufferSize);
            fin.Close();
            scriptsData.Add(fileParams);
        }
    }
}
