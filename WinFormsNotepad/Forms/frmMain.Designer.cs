namespace WinFormsNotepad.Forms
{
    partial class frmMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoPreviousActionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoBreakLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLineNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLineNumberToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtBoxNotePad = new System.Windows.Forms.TextBox();
            this.lblNumberOfLines = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maximizeToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.capitalizeToolStripMenuItem,
            this.undoPreviousActionToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            this.maximizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.maximizeToolStripMenuItem.Text = "Maximize Text";
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.maximizeToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize Text";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // capitalizeToolStripMenuItem
            // 
            this.capitalizeToolStripMenuItem.Name = "capitalizeToolStripMenuItem";
            this.capitalizeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.capitalizeToolStripMenuItem.Text = "Capitalize Lines";
            this.capitalizeToolStripMenuItem.Click += new System.EventHandler(this.capitalizeToolStripMenuItem_Click);
            // 
            // undoPreviousActionToolStripMenuItem
            // 
            this.undoPreviousActionToolStripMenuItem.Name = "undoPreviousActionToolStripMenuItem";
            this.undoPreviousActionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.undoPreviousActionToolStripMenuItem.Text = "Undo Previous Action";
            this.undoPreviousActionToolStripMenuItem.Click += new System.EventHandler(this.undoPreviousActionToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoBreakLinesToolStripMenuItem,
            this.showLineNumberToolStripMenuItem1,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // autoBreakLinesToolStripMenuItem
            // 
            this.autoBreakLinesToolStripMenuItem.CheckOnClick = true;
            this.autoBreakLinesToolStripMenuItem.Name = "autoBreakLinesToolStripMenuItem";
            this.autoBreakLinesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.autoBreakLinesToolStripMenuItem.Text = "Automatically break lines";
            this.autoBreakLinesToolStripMenuItem.Click += new System.EventHandler(this.autoBreakLinesToolStripMenuItem_Click);
            // 
            // showLineNumberToolStripMenuItem1
            // 
            this.showLineNumberToolStripMenuItem1.CheckOnClick = true;
            this.showLineNumberToolStripMenuItem1.Name = "showLineNumberToolStripMenuItem1";
            this.showLineNumberToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.showLineNumberToolStripMenuItem1.Text = "Show line number";
            this.showLineNumberToolStripMenuItem1.Click += new System.EventHandler(this.showLineNumberToolStripMenuItem1_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // showLineNumberToolStripMenuItem
            // 
            this.showLineNumberToolStripMenuItem.AutoClose = false;
            this.showLineNumberToolStripMenuItem.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.showLineNumberToolStripMenuItem.Name = "showLineNumberToolStripMenuItem";
            this.showLineNumberToolStripMenuItem.OwnerItem = this.formatToolStripMenuItem;
            this.showLineNumberToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.contactToolStripMenuItem.Text = "Contact Us";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtBoxNotePad
            // 
            this.txtBoxNotePad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNotePad.Location = new System.Drawing.Point(22, 27);
            this.txtBoxNotePad.Multiline = true;
            this.txtBoxNotePad.Name = "txtBoxNotePad";
            this.txtBoxNotePad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxNotePad.Size = new System.Drawing.Size(784, 410);
            this.txtBoxNotePad.TabIndex = 3;
            this.txtBoxNotePad.WordWrap = false;
            this.txtBoxNotePad.Click += new System.EventHandler(this.txtBoxNotePad_Click);
            this.txtBoxNotePad.SizeChanged += new System.EventHandler(this.txtBoxNotePad_SizeChanged);
            this.txtBoxNotePad.TextChanged += new System.EventHandler(this.txtBoxNotePad_TextChanged);
            // 
            // lblNumberOfLines
            // 
            this.lblNumberOfLines.AutoSize = true;
            this.lblNumberOfLines.Location = new System.Drawing.Point(0, 30);
            this.lblNumberOfLines.Name = "lblNumberOfLines";
            this.lblNumberOfLines.Size = new System.Drawing.Size(0, 15);
            this.lblNumberOfLines.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 448);
            this.Controls.Add(this.lblNumberOfLines);
            this.Controls.Add(this.txtBoxNotePad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyNotePad";
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem newWindowToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem capitalizeToolStripMenuItem;
        private ToolStripMenuItem undoPreviousActionToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem autoBreakLinesToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripDropDownMenu showLineNumberToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem contactToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TextBox txtBoxNotePad;
        private Label lblNumberOfLines;
        private ToolStripMenuItem showLineNumberToolStripMenuItem1;
    }
}