using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class FileBrowser : Form
    {
        List<string> listFiles = new List<string>();
        public FileBrowser()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView1.Items.Clear();
            using(FolderBrowserDialog f = new FolderBrowserDialog() {Description ="Select the path" })
            {
                if(f.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = f.SelectedPath;
                    new BackOfficeAdManager().setPath(f.SelectedPath);
                    foreach(string item in Directory.GetFiles(f.SelectedPath))
                    {
                        imageList.Images.Add(Icon.ExtractAssociatedIcon(item));
                        FileInfo fi = new FileInfo(item);
                        listFiles.Add(fi.FullName);
                        listView1.Items.Add(fi.Name, imageList.Images.Count - 1);
                    }
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.FocusedItem != null) Process.Start(listFiles[listView1.FocusedItem.Index]);
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
