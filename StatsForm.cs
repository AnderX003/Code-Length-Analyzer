using System.IO;
using System.Windows.Forms;

namespace CodeLengthAnalyze
{
    public partial class StatsForm : Form
    {
        private struct ScriptData
        {
            public string FileName;
            public string fullDirectory;
            public int linesOfCode;
            public int emptyStrings;
            public int dotComaCount;
        }

        private readonly string[] directories;
        private readonly string[] formats;
        private ScriptData[] scriptsData;

        public StatsForm(string[] directories, string[] formats)
        {
            InitializeComponent();
            this.directories = directories;
            this.formats = formats;

            Analyze();
            DrawTotalInfo();
            DrawScriptsLinesOfCode();
        }

        private void Analyze()
        {
            //Directory.
        }

        private void DrawTotalInfo() { }

        private void DrawScriptsLinesOfCode()
        {
            var items = listViewScriptsDetails.Items;
            foreach (var scriptData in scriptsData)
            {
                var item = new ListViewItem(scriptData.fullDirectory);
                item.SubItems.Add(scriptData.linesOfCode.ToString());
                items.Add(item);
            }
        }
    }
}
