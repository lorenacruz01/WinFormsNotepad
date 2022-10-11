using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsNotepad.Services;

namespace WinFormsNotepad.Forms
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
        }

        private void btnContactCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContactSend_Click(object sender, EventArgs e)
        {
            string clientName = txtBoxContactFirstName.Text + " " + txtContactLastName.Text;
            string clientEmail = txtBoxReplyTo.Text;
            string subject = txtBoxContactSubject.Text;
            string message = txtBoxContactMessage.Text;

            EmailSender emailSender = new EmailSender(clientEmail, clientName, message, subject);
            emailSender.SendEmail();
        }
    }
}
