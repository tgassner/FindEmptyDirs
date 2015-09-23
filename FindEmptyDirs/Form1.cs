using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FindEmptyDirs {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBoxRoot.Focus();
        }

        private void enabled(bool value){
            textBoxRoot.Enabled = value;
            buttonFind.Enabled = value;
            textBoxExcludes.Enabled = value;
            buttonFindRoot.Enabled = value;
            listBoxResult.Enabled = value;
            buttonDeleteSelectedDirs.Enabled = value;
            buttonSelectAll.Enabled = value;
            buttonUnSelectAll.Enabled = value;
            buttonAbout.Enabled = value;
            //listBoxErrors.Enabled = value;
        }

        private void buttonFind_Click(object sender, EventArgs e) {
            listBoxResult.Items.Clear();
            listBoxErrors.Items.Clear();
            textBoxDirsFound.Text = "";
            if (!Directory.Exists(textBoxRoot.Text)) {
                MessageBox.Show("Root must exist!!!");
                return;
            }
            enabled(false);
            Queue<string> searchQueue = new Queue<string>();
            List<string> resultList = new List<string>();
            string[] excludeList = textBoxExcludes.Text.Split(' ');
            searchQueue.Enqueue(textBoxRoot.Text);
            while (searchQueue.Count > 0) {
                Application.DoEvents();
                string currentDir = searchQueue.Dequeue();
                try {
                    string[] files = Directory.GetFiles(currentDir);
                    string[] dirs = Directory.GetDirectories(currentDir);

                    if ((files.Length == 0) && (dirs.Length == 0)){
                        bool addDir = true;

                        if (!((excludeList.Length == 1) && (excludeList[0].Equals("")))) {
                            foreach (string exclude in excludeList) {
                                if (currentDir.Contains(exclude)) {
                                    addDir = false;
                                }
                            }
                        }
                        if (addDir) {
                            resultList.Add(currentDir);
                        }
                    }

                    foreach (string dir in dirs) {
                        searchQueue.Enqueue(dir);
                    }

                } catch (UnauthorizedAccessException uoae) {
                    listBoxErrors.Items.Add(uoae.Message);
                };
            }
            foreach (string str in resultList) {
                Application.DoEvents();
                listBoxResult.Items.Add(str);
            }
            textBoxDirsFound.Text = listBoxResult.Items.Count.ToString();
            enabled(true);
        }

        private void buttonFindRoot_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dres = fbd.ShowDialog();
            if (dres == DialogResult.OK) {
                textBoxRoot.Text = fbd.SelectedPath;
            }
        }

        private void buttonDeleteSelectedDirs_Click(object sender, EventArgs e) {
            enabled(false);
            listBoxErrors.Items.Clear();
            foreach (string dir in listBoxResult.SelectedItems) {
                Application.DoEvents();
                //Show if it is really empty
                if ((Directory.GetFiles(dir).Length == 0) && (Directory.GetDirectories(dir).Length == 0)) {
                    try {
                        Directory.Delete(dir);
                    } catch (Exception exc) {
                        listBoxErrors.Items.Add(exc.Message);
                    };
                }
            }
            listBoxResult.Items.Clear();
            textBoxDirsFound.Text = "";
            enabled(true);
            MessageBox.Show("Files deleted\r\nPlease research for the rest or\r\nDirectories that haven't been able to delete");
        }

        private void buttonSelectAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < listBoxResult.Items.Count; i++) {
                listBoxResult.SetSelected(i, true);
            }
        }

        private void buttonUnSelectAll_Click(object sender, EventArgs e) {
            for (int i = 0; i < listBoxResult.Items.Count; i++) {
                listBoxResult.SetSelected(i, false);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e) {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}