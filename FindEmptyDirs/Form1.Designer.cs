namespace FindEmptyDirs {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonFindRoot = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRoot = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxExcludes = new System.Windows.Forms.TextBox();
            this.labelExcludes = new System.Windows.Forms.Label();
            this.labelExcludesExample = new System.Windows.Forms.Label();
            this.labelDirsFound = new System.Windows.Forms.Label();
            this.textBoxDirsFound = new System.Windows.Forms.TextBox();
            this.buttonDeleteSelectedDirs = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonUnSelectAll = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.listBoxErrors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonFindRoot
            // 
            this.buttonFindRoot.Location = new System.Drawing.Point(795, 32);
            this.buttonFindRoot.Name = "buttonFindRoot";
            this.buttonFindRoot.Size = new System.Drawing.Size(75, 23);
            this.buttonFindRoot.TabIndex = 4;
            this.buttonFindRoot.Text = "Find &Root";
            this.buttonFindRoot.UseVisualStyleBackColor = true;
            this.buttonFindRoot.Click += new System.EventHandler(this.buttonFindRoot_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(12, 62);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxResult.Size = new System.Drawing.Size(858, 368);
            this.listBoxResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Root:";
            // 
            // textBoxRoot
            // 
            this.textBoxRoot.Location = new System.Drawing.Point(48, 7);
            this.textBoxRoot.Name = "textBoxRoot";
            this.textBoxRoot.Size = new System.Drawing.Size(822, 20);
            this.textBoxRoot.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 33);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "&Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxExcludes
            // 
            this.textBoxExcludes.Location = new System.Drawing.Point(216, 35);
            this.textBoxExcludes.Name = "textBoxExcludes";
            this.textBoxExcludes.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcludes.TabIndex = 2;
            // 
            // labelExcludes
            // 
            this.labelExcludes.AutoSize = true;
            this.labelExcludes.Location = new System.Drawing.Point(154, 38);
            this.labelExcludes.Name = "labelExcludes";
            this.labelExcludes.Size = new System.Drawing.Size(56, 13);
            this.labelExcludes.TabIndex = 6;
            this.labelExcludes.Text = "Excludes: ";
            // 
            // labelExcludesExample
            // 
            this.labelExcludesExample.AutoSize = true;
            this.labelExcludesExample.Location = new System.Drawing.Point(322, 38);
            this.labelExcludesExample.Name = "labelExcludesExample";
            this.labelExcludesExample.Size = new System.Drawing.Size(80, 13);
            this.labelExcludesExample.TabIndex = 7;
            this.labelExcludesExample.Text = "e.g.: svn secret";
            // 
            // labelDirsFound
            // 
            this.labelDirsFound.AutoSize = true;
            this.labelDirsFound.Location = new System.Drawing.Point(497, 38);
            this.labelDirsFound.Name = "labelDirsFound";
            this.labelDirsFound.Size = new System.Drawing.Size(58, 13);
            this.labelDirsFound.TabIndex = 8;
            this.labelDirsFound.Text = "Dirs found:";
            // 
            // textBoxDirsFound
            // 
            this.textBoxDirsFound.Enabled = false;
            this.textBoxDirsFound.Location = new System.Drawing.Point(561, 35);
            this.textBoxDirsFound.Name = "textBoxDirsFound";
            this.textBoxDirsFound.Size = new System.Drawing.Size(100, 20);
            this.textBoxDirsFound.TabIndex = 3;
            // 
            // buttonDeleteSelectedDirs
            // 
            this.buttonDeleteSelectedDirs.Location = new System.Drawing.Point(12, 434);
            this.buttonDeleteSelectedDirs.Name = "buttonDeleteSelectedDirs";
            this.buttonDeleteSelectedDirs.Size = new System.Drawing.Size(139, 23);
            this.buttonDeleteSelectedDirs.TabIndex = 6;
            this.buttonDeleteSelectedDirs.Text = "&Delete Selected Dirs";
            this.buttonDeleteSelectedDirs.UseVisualStyleBackColor = true;
            this.buttonDeleteSelectedDirs.Click += new System.EventHandler(this.buttonDeleteSelectedDirs_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(216, 434);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 7;
            this.buttonSelectAll.Text = "&Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonUnSelectAll
            // 
            this.buttonUnSelectAll.Location = new System.Drawing.Point(298, 434);
            this.buttonUnSelectAll.Name = "buttonUnSelectAll";
            this.buttonUnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonUnSelectAll.TabIndex = 8;
            this.buttonUnSelectAll.Text = "&UnSelect All";
            this.buttonUnSelectAll.UseVisualStyleBackColor = true;
            this.buttonUnSelectAll.Click += new System.EventHandler(this.buttonUnSelectAll_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(795, 434);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "&About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // listBoxErrors
            // 
            this.listBoxErrors.Enabled = false;
            this.listBoxErrors.FormattingEnabled = true;
            this.listBoxErrors.Location = new System.Drawing.Point(12, 463);
            this.listBoxErrors.Name = "listBoxErrors";
            this.listBoxErrors.Size = new System.Drawing.Size(858, 108);
            this.listBoxErrors.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 579);
            this.Controls.Add(this.listBoxErrors);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonUnSelectAll);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.buttonDeleteSelectedDirs);
            this.Controls.Add(this.textBoxDirsFound);
            this.Controls.Add(this.labelDirsFound);
            this.Controls.Add(this.labelExcludesExample);
            this.Controls.Add(this.labelExcludes);
            this.Controls.Add(this.textBoxExcludes);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonFindRoot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Empty Directories 1.1 by Thomas Gassner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindRoot;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRoot;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxExcludes;
        private System.Windows.Forms.Label labelExcludes;
        private System.Windows.Forms.Label labelExcludesExample;
        private System.Windows.Forms.Label labelDirsFound;
        private System.Windows.Forms.TextBox textBoxDirsFound;
        private System.Windows.Forms.Button buttonDeleteSelectedDirs;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonUnSelectAll;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.ListBox listBoxErrors;
    }
}

