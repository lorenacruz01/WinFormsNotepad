namespace WinFormsNotepad.Forms
{
    partial class frmMailError
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
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblEmailErrorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailError.Location = new System.Drawing.Point(49, 9);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(171, 19);
            this.lblEmailError.TabIndex = 1;
            this.lblEmailError.Text = "An error has ocurred!";
            // 
            // lblEmailErrorText
            // 
            this.lblEmailErrorText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEmailErrorText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailErrorText.Location = new System.Drawing.Point(0, 41);
            this.lblEmailErrorText.Name = "lblEmailErrorText";
            this.lblEmailErrorText.Size = new System.Drawing.Size(292, 76);
            this.lblEmailErrorText.TabIndex = 2;
            this.lblEmailErrorText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMailError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 117);
            this.Controls.Add(this.lblEmailErrorText);
            this.Controls.Add(this.lblEmailError);
            this.MaximizeBox = false;
            this.Name = "frmMailError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmailError;
        private Label lblEmailErrorText;
    }
}