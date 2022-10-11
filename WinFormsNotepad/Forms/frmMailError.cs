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
    public partial class frmMailError : Form
    {
        public string ErrorMsg = "";
        public frmMailError()
        {
            InitializeComponent();
        }

        public frmMailError(string errorMsg)
        {
            InitializeComponent();
            ErrorMsg = errorMsg;
            if(ErrorMsg != "")
            {
                lblEmailErrorText.Text = ErrorMsg;
            }
        }
    }
}
