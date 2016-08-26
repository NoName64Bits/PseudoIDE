namespace PseudoIDE
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fileTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compileTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.runTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutTool = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editor = new ICSharpCode.TextEditor.TextEditorControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.infoTab = new System.Windows.Forms.TabPage();
            this.infoRich = new System.Windows.Forms.RichTextBox();
            this.gppTab = new System.Windows.Forms.TabPage();
            this.gppRich = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.saveAsFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.infoTab.SuspendLayout();
            this.gppTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Everything is OK!";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTool,
            this.toolStripSeparator2,
            this.compileTool,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.runTool,
            this.toolStripSeparator3,
            this.aboutTool});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(781, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // fileTool
            // 
            this.fileTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileTool.Image = ((System.Drawing.Image)(resources.GetObject("fileTool.Image")));
            this.fileTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileTool.Name = "fileTool";
            this.fileTool.Size = new System.Drawing.Size(29, 22);
            this.fileTool.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // compileTool
            // 
            this.compileTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compileTool.Image = ((System.Drawing.Image)(resources.GetObject("compileTool.Image")));
            this.compileTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.compileTool.Name = "compileTool";
            this.compileTool.Size = new System.Drawing.Size(23, 22);
            this.compileTool.Text = "Compile";
            this.compileTool.Click += new System.EventHandler(this.compileTool_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Compiler Mode:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Build",
            "Build and run",
            "Generate C++ code"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(150, 25);
            this.toolStripComboBox1.Text = "Build and run";
            // 
            // runTool
            // 
            this.runTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.runTool.Image = ((System.Drawing.Image)(resources.GetObject("runTool.Image")));
            this.runTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.runTool.Name = "runTool";
            this.runTool.Size = new System.Drawing.Size(23, 22);
            this.runTool.Text = "Run";
            this.runTool.Click += new System.EventHandler(this.runTool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutTool
            // 
            this.aboutTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutTool.Image = ((System.Drawing.Image)(resources.GetObject("aboutTool.Image")));
            this.aboutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutTool.Name = "aboutTool";
            this.aboutTool.Size = new System.Drawing.Size(23, 22);
            this.aboutTool.Text = "About";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.editor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.06635F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93365F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 422);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.IsReadOnly = false;
            this.editor.Location = new System.Drawing.Point(3, 3);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(775, 315);
            this.editor.TabIndex = 0;
            this.editor.Text = "START\r\n\r\nSTOP";
            this.editor.Load += new System.EventHandler(this.editor_Load);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.infoTab);
            this.tabControl1.Controls.Add(this.gppTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 324);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 95);
            this.tabControl1.TabIndex = 1;
            // 
            // infoTab
            // 
            this.infoTab.Controls.Add(this.infoRich);
            this.infoTab.Location = new System.Drawing.Point(4, 22);
            this.infoTab.Name = "infoTab";
            this.infoTab.Padding = new System.Windows.Forms.Padding(3);
            this.infoTab.Size = new System.Drawing.Size(767, 69);
            this.infoTab.TabIndex = 1;
            this.infoTab.Text = "Info";
            this.infoTab.UseVisualStyleBackColor = true;
            // 
            // infoRich
            // 
            this.infoRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoRich.Location = new System.Drawing.Point(3, 3);
            this.infoRich.Name = "infoRich";
            this.infoRich.Size = new System.Drawing.Size(761, 63);
            this.infoRich.TabIndex = 0;
            this.infoRich.Text = "";
            // 
            // gppTab
            // 
            this.gppTab.Controls.Add(this.gppRich);
            this.gppTab.Location = new System.Drawing.Point(4, 22);
            this.gppTab.Name = "gppTab";
            this.gppTab.Padding = new System.Windows.Forms.Padding(3);
            this.gppTab.Size = new System.Drawing.Size(767, 69);
            this.gppTab.TabIndex = 0;
            this.gppTab.Text = "G++ Output";
            this.gppTab.UseVisualStyleBackColor = true;
            // 
            // gppRich
            // 
            this.gppRich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gppRich.Location = new System.Drawing.Point(3, 3);
            this.gppRich.Name = "gppRich";
            this.gppRich.Size = new System.Drawing.Size(761, 63);
            this.gppRich.TabIndex = 0;
            this.gppRich.Text = "";
            // 
            // openFile
            // 
            this.openFile.Filter = "PseudoIDE Project File (*.pscp)|*pscp|All files|*.*";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "PseudoIDE Project File (*.pscp)|*.pscp|All fles|*.*";
            this.saveFile.Title = "Save";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveAsFile
            // 
            this.saveAsFile.Title = "Save As";
            this.saveAsFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAsFile_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(781, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PseudoIDE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.infoTab.ResumeLayout(false);
            this.gppTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ICSharpCode.TextEditor.TextEditorControl editor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage infoTab;
        private System.Windows.Forms.TabPage gppTab;
        private System.Windows.Forms.RichTextBox infoRich;
        private System.Windows.Forms.RichTextBox gppRich;
        private System.Windows.Forms.ToolStripDropDownButton fileTool;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton compileTool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton runTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton aboutTool;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveAsFile;
    }
}

