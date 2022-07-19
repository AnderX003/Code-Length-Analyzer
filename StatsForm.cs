using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CodeLengthAnalyze
{
    public partial class StatsForm : Form
    {
        private struct ScriptData
        {
            public string FileName;
            public string FullDirectory;
            public int LinesOfCode;
            public int EmptyStrings;
            public int DotComaCount;
        }

        private readonly string[] directories;
        private readonly string[] formats;
        private readonly List<ScriptData> scriptsData = new List<ScriptData>(20);
        private readonly Func<char, bool> isDotComaChar;

        public StatsForm(string[] directories, string[] formats)
        {
            InitializeComponent();
            this.directories = directories;
            this.formats = formats;
            isDotComaChar = c => c == ';';

            var startTime = DateTime.Now;
            Analyze();
            if (scriptsData == null || scriptsData.Count == 0)
            {
                //Close
                return;
            }

            scriptsData.Sort((a, b) => a.LinesOfCode >= b.LinesOfCode ? -1 : 1);
            DrawTotalInfo(DateTime.Now - startTime);
            DrawScriptsLinesOfCode();
        }

        //private async void AnalyzeAsync() => await Task.Run(Analyze);

        private void Analyze()
        {
            foreach (var path in directories)
            foreach (var format in formats)
                SearchByExtension(path, format);
        }

        private void SearchByExtension(string rootPath, string extension)
        {
            string[] files;
            try
            {
                files = Directory.GetFiles(rootPath, $"*{extension}", SearchOption.AllDirectories);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error occured:\n{e.Message}");
                return;
            }

            foreach (var file in files) AnalyzeFile(file);
        }

        private void AnalyzeFile(string path)
        {
            var fileParams = new ScriptData
            {
                FullDirectory = path,
                FileName = Path.GetFileName(path)
            };

            var fin = File.OpenText(path);
            string line;
            while ((line = fin.ReadLine()) != null)
            {
                fileParams.LinesOfCode++;
                fileParams.DotComaCount += line.Count(isDotComaChar);
                if (string.IsNullOrWhiteSpace(line)) fileParams.EmptyStrings++;
            }

            scriptsData.Add(fileParams);
        }

        private void DrawTotalInfo(TimeSpan analyzeTime)
        {
            var items = listViewTotal.Items;

            var item = new ListViewItem("Files count");
            item.SubItems.Add(scriptsData.Count.ToString());
            items.Add(item);

            item = new ListViewItem("Lines of code");
            item.SubItems.Add(scriptsData.Sum(i => i.LinesOfCode).ToString());
            items.Add(item);

            item = new ListViewItem("Empty strings");
            item.SubItems.Add(scriptsData.Sum(i => i.EmptyStrings).ToString());
            items.Add(item);

            item = new ListViewItem("';' count");
            item.SubItems.Add(scriptsData.Sum(i => i.DotComaCount).ToString());
            items.Add(item);

            item = new ListViewItem("Analyze time");
            item.SubItems.Add(analyzeTime.ToString());
            items.Add(item);
        }

        private void DrawScriptsLinesOfCode()
        {
            var items = listViewScriptsDetails.Items;
            foreach (var scriptData in scriptsData)
            {
                var item = new ListViewItem(scriptData.FileName);
                item.SubItems.Add(scriptData.LinesOfCode.ToString());
                item.SubItems.Add(scriptData.FullDirectory);
                item.SubItems.Add(scriptData.DotComaCount.ToString());
                item.SubItems.Add(scriptData.EmptyStrings.ToString());
                items.Add(item);
            }
        }
    }
}
