namespace SimpleEditor
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.editorTxt = new System.Windows.Forms.RichTextBox();
            this.printSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileTSMI,
            this.newWindowTSMI,
            this.openFileTSMI,
            this.saveFileTSMI,
            this.saveFileAsTSMI,
            this.toolStripSeparator2,
            this.printSMI,
            this.toolStripSeparator1,
            this.closeTSMI});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // newFileTSMI
            // 
            this.newFileTSMI.Name = "newFileTSMI";
            this.newFileTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileTSMI.Size = new System.Drawing.Size(291, 22);
            this.newFileTSMI.Text = "Neu";
            this.newFileTSMI.Click += new System.EventHandler(this.newFileTSMI_Click);
            // 
            // newWindowTSMI
            // 
            this.newWindowTSMI.Name = "newWindowTSMI";
            this.newWindowTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowTSMI.Size = new System.Drawing.Size(291, 22);
            this.newWindowTSMI.Text = "Neues Fenster";
            this.newWindowTSMI.Click += new System.EventHandler(this.newWindowTSMI_Click);
            // 
            // openFileTSMI
            // 
            this.openFileTSMI.Name = "openFileTSMI";
            this.openFileTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileTSMI.Size = new System.Drawing.Size(291, 22);
            this.openFileTSMI.Text = "Öffnen...";
            this.openFileTSMI.Click += new System.EventHandler(this.openFileTSMI_Click);
            // 
            // saveFileTSMI
            // 
            this.saveFileTSMI.Name = "saveFileTSMI";
            this.saveFileTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileTSMI.Size = new System.Drawing.Size(291, 22);
            this.saveFileTSMI.Text = "Speichern";
            this.saveFileTSMI.Click += new System.EventHandler(this.saveFileTSMI_Click);
            // 
            // saveFileAsTSMI
            // 
            this.saveFileAsTSMI.Name = "saveFileAsTSMI";
            this.saveFileAsTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAsTSMI.Size = new System.Drawing.Size(291, 22);
            this.saveFileAsTSMI.Text = "Speichern unter,,,";
            this.saveFileAsTSMI.Click += new System.EventHandler(this.saveFileAsTSMI_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // closeTSMI
            // 
            this.closeTSMI.Name = "closeTSMI";
            this.closeTSMI.Size = new System.Drawing.Size(291, 22);
            this.closeTSMI.Text = "Beenden";
            this.closeTSMI.Click += new System.EventHandler(this.closeTSMI_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // editorTxt
            // 
            this.editorTxt.AcceptsTab = true;
            this.editorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editorTxt.AutoWordSelection = true;
            this.editorTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editorTxt.EnableAutoDragDrop = true;
            this.editorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorTxt.Location = new System.Drawing.Point(0, 25);
            this.editorTxt.Name = "editorTxt";
            this.editorTxt.Size = new System.Drawing.Size(800, 426);
            this.editorTxt.TabIndex = 1;
            this.editorTxt.Text = "";
            // 
            // printSMI
            // 
            this.printSMI.Name = "printSMI";
            this.printSMI.Size = new System.Drawing.Size(291, 22);
            this.printSMI.Text = "Drucken";
            this.printSMI.Click += new System.EventHandler(this.printSMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(288, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editorTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem newWindowTSMI;
        private System.Windows.Forms.ToolStripMenuItem openFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveFileTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeTSMI;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.RichTextBox editorTxt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printSMI;
    }
}