namespace ConfigEditor.Ui
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.openFileDialogBrowser = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLoadFile = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tspExitApp = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbServerlist = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(12, 98);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(765, 38);
            this.tbFilePath.TabIndex = 0;
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(12, 64);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(249, 31);
            this.lbFilePath.TabIndex = 2;
            this.lbFilePath.Text = "Configurationsdatei";
            // 
            // openFileDialogBrowser
            // 
            this.openFileDialogBrowser.FileName = "openFileDialogBrowser";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBrowse,
            this.toolStripSeparator1,
            this.tslLoadFile,
            this.tsbSaveFile,
            this.toolStripSeparator2,
            this.tspExitApp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBrowse
            // 
            this.tsbBrowse.Image = ((System.Drawing.Image)(resources.GetObject("tsbBrowse.Image")));
            this.tsbBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrowse.Name = "tsbBrowse";
            this.tsbBrowse.Size = new System.Drawing.Size(85, 22);
            this.tsbBrowse.Text = "Auswählen";
            this.tsbBrowse.ToolTipText = "Auswählen";
            this.tsbBrowse.Click += new System.EventHandler(this.tsbBrowse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslLoadFile
            // 
            this.tslLoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tslLoadFile.Image = ((System.Drawing.Image)(resources.GetObject("tslLoadFile.Image")));
            this.tslLoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslLoadFile.Name = "tslLoadFile";
            this.tslLoadFile.Size = new System.Drawing.Size(23, 22);
            this.tslLoadFile.ToolTipText = "Datei laden";
            this.tslLoadFile.Click += new System.EventHandler(this.tslLoadFile_Click);
            // 
            // tsbSaveFile
            // 
            this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveFile.Image")));
            this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveFile.Name = "tsbSaveFile";
            this.tsbSaveFile.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveFile.ToolTipText = "Datei speichern";
            this.tsbSaveFile.Click += new System.EventHandler(this.tsbSaveFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tspExitApp
            // 
            this.tspExitApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspExitApp.Image = ((System.Drawing.Image)(resources.GetObject("tspExitApp.Image")));
            this.tspExitApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspExitApp.Name = "tspExitApp";
            this.tspExitApp.Size = new System.Drawing.Size(23, 22);
            this.tspExitApp.ToolTipText = "Tool beenden";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(765, 133);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbServerlist
            // 
            this.lbServerlist.AutoSize = true;
            this.lbServerlist.Location = new System.Drawing.Point(12, 158);
            this.lbServerlist.Name = "lbServerlist";
            this.lbServerlist.Size = new System.Drawing.Size(143, 31);
            this.lbServerlist.TabIndex = 5;
            this.lbServerlist.Text = "Serverliste";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.lbServerlist);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.tbFilePath);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Config Editor";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowser;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tslLoadFile;
        private System.Windows.Forms.ToolStripButton tsbSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbBrowse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tspExitApp;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbServerlist;
    }
}

