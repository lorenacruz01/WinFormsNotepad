using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsNotepad.Forms
{
    public partial class frmMailSent : Form
    {
        public frmMailSent()
        {
            InitializeComponent();
        }

        private void btnEmailSentClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.OpenForms["frmContact"].Close();
        }
    }
}
