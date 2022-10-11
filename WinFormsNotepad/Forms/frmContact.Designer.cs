namespace WinFormsNotepad.Forms
{
    partial class frmContact
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
            this.lblContactFirstName = new System.Windows.Forms.Label();
            this.lblContactLastName = new System.Windows.Forms.Label();
            this.lblContactSubject = new System.Windows.Forms.Label();
            this.txtBoxContactFirstName = new System.Windows.Forms.TextBox();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.txtBoxContactSubject = new System.Windows.Forms.TextBox();
            this.lblContactReplyTo = new System.Windows.Forms.Label();
            this.txtBoxReplyTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxContactMessage = new System.Windows.Forms.TextBox();
            this.btnContactCancel = new System.Windows.Forms.Button();
            this.btnContactSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContactFirstName
            // 
            this.lblContactFirstName.AutoSize = true;
            this.lblContactFirstName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactFirstName.Location = new System.Drawing.Point(25, 15);
            this.lblContactFirstName.Name = "lblContactFirstName";
            this.lblContactFirstName.Size = new System.Drawing.Size(81, 20);
            this.lblContactFirstName.TabIndex = 0;
            this.lblContactFirstName.Text = "First Name: ";
            // 
            // lblContactLastName
            // 
            this.lblContactLastName.AutoSize = true;
            this.lblContactLastName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactLastName.Location = new System.Drawing.Point(25, 49);
            this.lblContactLastName.Name = "lblContactLastName";
            this.lblContactLastName.Size = new System.Drawing.Size(80, 20);
            this.lblContactLastName.TabIndex = 1;
            this.lblContactLastName.Text = "Last Name: ";
            // 
            // lblContactSubject
            // 
            this.lblContactSubject.AutoSize = true;
            this.lblContactSubject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactSubject.Location = new System.Drawing.Point(25, 124);
            this.lblContactSubject.Name = "lblContactSubject";
            this.lblContactSubject.Size = new System.Drawing.Size(62, 20);
            this.lblContactSubject.TabIndex = 2;
            this.lblContactSubject.Text = "Subject: ";
            // 
            // txtBoxContactFirstName
            // 
            this.txtBoxContactFirstName.Location = new System.Drawing.Point(112, 12);
            this.txtBoxContactFirstName.Name = "txtBoxContactFirstName";
            this.txtBoxContactFirstName.Size = new System.Drawing.Size(216, 23);
            this.txtBoxContactFirstName.TabIndex = 3;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Location = new System.Drawing.Point(112, 46);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(216, 23);
            this.txtContactLastName.TabIndex = 4;
            // 
            // txtBoxContactSubject
            // 
            this.txtBoxContactSubject.Location = new System.Drawing.Point(112, 121);
            this.txtBoxContactSubject.Name = "txtBoxContactSubject";
            this.txtBoxContactSubject.Size = new System.Drawing.Size(445, 23);
            this.txtBoxContactSubject.TabIndex = 5;
            // 
            // lblContactReplyTo
            // 
            this.lblContactReplyTo.AutoSize = true;
            this.lblContactReplyTo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactReplyTo.Location = new System.Drawing.Point(25, 83);
            this.lblContactReplyTo.Name = "lblContactReplyTo";
            this.lblContactReplyTo.Size = new System.Drawing.Size(78, 20);
            this.lblContactReplyTo.TabIndex = 6;
            this.lblContactReplyTo.Text = "Your Email:";
            // 
            // txtBoxReplyTo
            // 
            this.txtBoxReplyTo.Location = new System.Drawing.Point(112, 83);
            this.txtBoxReplyTo.Name = "txtBoxReplyTo";
            this.txtBoxReplyTo.Size = new System.Drawing.Size(357, 23);
            this.txtBoxReplyTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message:";
            // 
            // txtBoxContactMessage
            // 
            this.txtBoxContactMessage.Location = new System.Drawing.Point(112, 168);
            this.txtBoxContactMessage.Multiline = true;
            this.txtBoxContactMessage.Name = "txtBoxContactMessage";
            this.txtBoxContactMessage.Size = new System.Drawing.Size(445, 214);
            this.txtBoxContactMessage.TabIndex = 9;
            // 
            // btnContactCancel
            // 
            this.btnContactCancel.Location = new System.Drawing.Point(494, 408);
            this.btnContactCancel.Name = "btnContactCancel";
            this.btnContactCancel.Size = new System.Drawing.Size(92, 30);
            this.btnContactCancel.TabIndex = 10;
            this.btnContactCancel.Text = "Cancel";
            this.btnContactCancel.UseVisualStyleBackColor = true;
            this.btnContactCancel.Click += new System.EventHandler(this.btnContactCancel_Click);
            // 
            // btnContactSend
            // 
            this.btnContactSend.Location = new System.Drawing.Point(384, 408);
            this.btnContactSend.Name = "btnContactSend";
            this.btnContactSend.Size = new System.Drawing.Size(92, 30);
            this.btnContactSend.TabIndex = 11;
            this.btnContactSend.Text = "Send";
            this.btnContactSend.UseVisualStyleBackColor = true;
            this.btnContactSend.Click += new System.EventHandler(this.btnContactSend_Click);
            // 
            // frmContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.btnContactSend);
            this.Controls.Add(this.btnContactCancel);
            this.Controls.Add(this.txtBoxContactMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxReplyTo);
            this.Controls.Add(this.lblContactReplyTo);
            this.Controls.Add(this.txtBoxContactSubject);
            this.Controls.Add(this.txtContactLastName);
            this.Controls.Add(this.txtBoxContactFirstName);
            this.Controls.Add(this.lblContactSubject);
            this.Controls.Add(this.lblContactLastName);
            this.Controls.Add(this.lblContactFirstName);
            this.Name = "frmContact";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblContactFirstName;
        private Label lblContactLastName;
        private Label lblContactSubject;
        private TextBox txtBoxContactFirstName;
        private TextBox txtContactLastName;
        private TextBox txtBoxContactSubject;
        private Label lblContactReplyTo;
        private TextBox txtBoxReplyTo;
        private Label label1;
        private TextBox txtBoxContactMessage;
        private Button btnContactCancel;
        private Button btnContactSend;
    }
}