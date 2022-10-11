using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WinFormsNotepad.Forms;

namespace WinFormsNotepad.Services
{
    
    internal class EmailSender
    {

        public MailAddress ToEmail { get; set; }
        public string ClientName { get; set;}
        public MailMessage Message { get; set; }
        public string MailSubject { get; set; }
        
          
        SmtpClient Client = new SmtpClient()
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential()
            {
                UserName = "your gmail",
                Password = "your password"
            }
            
        };

        public EmailSender(string clientEmail, string clientName, string message, string subject)
        {
            
            
            MailAddress FromEmail = new MailAddress("your gmail", "Notepad Support");
            ClientName = clientName;
            ToEmail = new MailAddress("your gmail", "Notepad Suport");
            MailSubject = subject;
            Message = new MailMessage()
            {
                From = FromEmail,
                Subject = MailSubject,
                Body = message
            };

            Message.To.Add(ToEmail);
            Message.ReplyToList.Add(new MailAddress(clientEmail, clientName));
        }

        public void SendEmail()
        {
            try
            {
                Client.Send(Message);
                frmMailSent frmMailSent= new frmMailSent();
                frmMailSent.ShowDialog();
            }
            catch (Exception ex)
            {
                string msg = "An exception has ocurred: " + ex.Message + " Please, try again!";
                frmMailError frmMailError = new frmMailError(msg);
                frmMailError.ShowDialog();
            }
            
        }



    }
}
