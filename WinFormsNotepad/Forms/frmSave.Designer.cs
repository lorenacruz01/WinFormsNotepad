namespace WinFormsNotepad.Forms
{
    partial class frmSave
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
            this.btnYesSave = new System.Windows.Forms.Button();
            this.btnDontSave = new System.Windows.Forms.Button();
            this.btnCancelSave = new System.Windows.Forms.Button();
            this.lblSaveMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYesSave
            // 
            this.btnYesSave.Location = new System.Drawing.Point(28, 86);
            this.btnYesSave.Name = "btnYesSave";
            this.btnYesSave.Size = new System.Drawing.Size(87, 38);
            this.btnYesSave.TabIndex = 1;
            this.btnYesSave.Text = "Save";
            this.btnYesSave.UseVisualStyleBackColor = true;
            this.btnYesSave.Click += new System.EventHandler(this.btnYesSave_Click);
            // 
            // btnDontSave
            // 
            this.btnDontSave.AutoSize = true;
            this.btnDontSave.Location = new System.Drawing.Point(133, 86);
            this.btnDontSave.Name = "btnDontSave";
            this.btnDontSave.Size = new System.Drawing.Size(87, 38);
            this.btnDontSave.TabIndex = 2;
            this.btnDontSave.Text = "Don\'t Save";
            this.btnDontSave.UseVisualStyleBackColor = true;
            this.btnDontSave.Click += new System.EventHandler(this.btnDontSave_Click);
            // 
            // btnCancelSave
            // 
            this.btnCancelSave.AutoSize = true;
            this.btnCancelSave.Location = new System.Drawing.Point(241, 86);
            this.btnCancelSave.Name = "btnCancelSave";
            this.btnCancelSave.Size = new System.Drawing.Size(87, 38);
            this.btnCancelSave.TabIndex = 3;
            this.btnCancelSave.Text = "Cancel";
            this.btnCancelSave.UseVisualStyleBackColor = true;
            this.btnCancelSave.Click += new System.EventHandler(this.btnCancelSave_Click);
            // 
            // lblSaveMsg
            // 
            this.lblSaveMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaveMsg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaveMsg.Location = new System.Drawing.Point(0, 0);
            this.lblSaveMsg.Name = "lblSaveMsg";
            this.lblSaveMsg.Size = new System.Drawing.Size(363, 83);
            this.lblSaveMsg.TabIndex = 4;
            this.lblSaveMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaveMsg.Click += new System.EventHandler(this.lblSaveMsg_Click);
            // 
            // frmSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(363, 131);
            this.Controls.Add(this.lblSaveMsg);
            this.Controls.Add(this.btnCancelSave);
            this.Controls.Add(this.btnDontSave);
            this.Controls.Add(this.btnYesSave);
            this.MaximizeBox = false;
            this.Name = "frmSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attention";
            this.Load += new System.EventHandler(this.frmSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnYesSave;
        private Button btnDontSave;
        private Button btnCancelSave;
        private Label lblSaveMsg;
    }
}