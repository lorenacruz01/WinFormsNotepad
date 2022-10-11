namespace WinFormsNotepad.Forms
{
    partial class frmMailSent
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
            this.lblEmailSent = new System.Windows.Forms.Label();
            this.lblEmailSentText = new System.Windows.Forms.Label();
            this.btnEmailSentClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmailSent
            // 
            this.lblEmailSent.AutoSize = true;
            this.lblEmailSent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailSent.Location = new System.Drawing.Point(49, 9);
            this.lblEmailSent.Name = "lblEmailSent";
            this.lblEmailSent.Size = new System.Drawing.Size(192, 19);
            this.lblEmailSent.TabIndex = 0;
            this.lblEmailSent.Text = "Email sent successfully!";
            // 
            // lblEmailSentText
            // 
            this.lblEmailSentText.AutoSize = true;
            this.lblEmailSentText.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailSentText.Location = new System.Drawing.Point(12, 41);
            this.lblEmailSentText.Name = "lblEmailSentText";
            this.lblEmailSentText.Size = new System.Drawing.Size(271, 30);
            this.lblEmailSentText.TabIndex = 1;
            this.lblEmailSentText.Text = "Thank you for getting in touch. Our support team \r\nwill reply your message as soo" +
    "n as possible.\r\n";
            // 
            // btnEmailSentClose
            // 
            this.btnEmailSentClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEmailSentClose.Location = new System.Drawing.Point(105, 84);
            this.btnEmailSentClose.Name = "btnEmailSentClose";
            this.btnEmailSentClose.Size = new System.Drawing.Size(75, 23);
            this.btnEmailSentClose.TabIndex = 2;
            this.btnEmailSentClose.Text = "OK";
            this.btnEmailSentClose.UseVisualStyleBackColor = true;
            this.btnEmailSentClose.Click += new System.EventHandler(this.btnEmailSentClose_Click);
            // 
            // frmMailSent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 119);
            this.Controls.Add(this.btnEmailSentClose);
            this.Controls.Add(this.lblEmailSentText);
            this.Controls.Add(this.lblEmailSent);
            this.MaximizeBox = false;
            this.Name = "frmMailSent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Done";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmailSent;
        private Label lblEmailSentText;
        private Button btnEmailSentClose;
    }
}