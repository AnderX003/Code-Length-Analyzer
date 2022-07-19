using System;
using System.Collections;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows.Forms;

namespace CodeLengthAnalyze
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            var types = new []
            {
                ".cs",
                ".cshtml",
                ".cpp",
                ".c",
                ".hpp",
                ".h",
                ".py",
                ".js",
                ".txt",
                ".pas"
            };
            
            var items = checkedListBoxTypes.Items;
            foreach (var type in types)
            {
                items.Add(type);
            }

            //set cs checked
            checkedListBoxTypes.SetItemChecked(0, true);
        }

        private void buttonAddDirectory_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            dialog.Multiselect = true;
            dialog.EnsurePathExists = true;
            
            if (dialog.ShowDialog() != CommonFileDialogResult.Ok) return;
            var items = listBoxDirectories.Items;
            foreach (var fileName in dialog.FileNames)
            {
                if(items.Contains(fileName)) continue;
                items.Add(fileName);
            }
        }

        private void buttonRemoveDirectory_Click(object sender, EventArgs e)
        {
            var selectedItem = listBoxDirectories.SelectedItem;
            if (selectedItem != null)
            {
                listBoxDirectories.Items.Remove(selectedItem);
            }
            else
            {
                if (listBoxDirectories.Items.Count <= 0) return;
                listBoxDirectories.Items.RemoveAt(0);
            }
        }

        private void buttonStartAnalyze_Click(object sender, EventArgs e)
        {
            if (!ValidateParams()) return;

            var statsForm = new StatsForm
            (
                ListToStringArray(listBoxDirectories.Items), 
                ListToStringArray(checkedListBoxTypes.CheckedItems)
            );

            //statsForm.Show();
            statsForm.ShowDialog();
        }

        private static string[] ListToStringArray(IList items)
        {
            var result = new string[items.Count];
            for (var i = 0; i < items.Count; i++)
                result[i] = (string) items[i];
            
            return result;
        }

        private bool ValidateParams() =>
            listBoxDirectories.Items.Count > 0 &&
            checkedListBoxTypes.CheckedItems.Count > 0;
    }
}
