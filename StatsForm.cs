using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CodeLengthAnalyze
{
    public partial class StatsForm : Form
    {
        public StatsForm(string[] directories, string[] formats)
        {
            InitializeComponent();

            var startTime = DateTime.Now;
            var analyzer = new FilesAnalyzer(directories, formats);
            var scriptsData = analyzer.Analyze(out bool result);
            if (!result)
            {
                Load += (_, _) => Close();
                return;
            }

            scriptsData.Sort((a, b) =>
            {
                if (b.LinesOfCode == a.LinesOfCode) return 0;
                return b.LinesOfCode > a.LinesOfCode ? 1 : -1;
            });
            
            DrawTotalInfo(scriptsData, DateTime.Now - startTime);
            DrawScriptsLinesOfCode(scriptsData);
        }

        private void DrawTotalInfo(IReadOnlyCollection<ScriptData> scriptsData, TimeSpan analyzeTime)
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
            item.SubItems.Add(string.Format("{0}:{1}:{2}.{3}",
                analyzeTime.Hours.ToString(),
                analyzeTime.Minutes.ToString(),
                analyzeTime.Seconds.ToString(),
                analyzeTime.Milliseconds.ToString()));
            items.Add(item);
        }

        private void DrawScriptsLinesOfCode(List<ScriptData> scriptsData)
        {
            var items = listViewScriptsDetails.Items;
            foreach (var scriptData in scriptsData)
            {
                var item = new ListViewItem(scriptData.FileName);
                item.SubItems.Add(scriptData.LinesOfCode.ToString());
                item.SubItems.Add(scriptData.EmptyStrings.ToString());
                item.SubItems.Add(scriptData.DotComaCount.ToString());
                item.SubItems.Add(scriptData.FullDirectory);
                items.Add(item);
            }
        }
    }
}
