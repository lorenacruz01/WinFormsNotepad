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
    public partial class frmSave : Form
    {
        public string FilePath = "";
        public string Content = "";

        public frmSave()
        {
            InitializeComponent();
        }

        public frmSave(string filePath, string content)
        {
            InitializeComponent();
            FilePath = filePath;
            Content = content;
            if (FilePath == "")
            {
                lblSaveMsg.Text = "The current project has not been saved yet. Would you like to save it?";
            } else
            {
                lblSaveMsg.Text = "Would you like to save the changes in " + FilePath + " ?";
            }
        }

        private void btnYesSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (FilePath == "")
            {
                saveFileDialog.Filter = "Text files|*txt";
                saveFileDialog.Title = "Save file as";
                saveFileDialog.ShowDialog();
                FilePath = saveFileDialog.FileName;
                if (!saveFileDialog.FileName.EndsWith(".txt"))
                {
                    FilePath = FilePath + ".txt";
                }
            }

            if (FilePath != "")
            {
                File.WriteAllText(FilePath, Content);
            }

            Content = "";
            FilePath = "";
            //newFrmMain.Closed += (s, args) => this.Close();
            //newFrmMain.ShowDialog();
            Close();
            
        }

        private void lblSaveMsg_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDontSave_Click(object sender, EventArgs e)
        {
            Content = "";
            FilePath = "";
            Close();
        }

        private void frmSave_Load(object sender, EventArgs e)
        {

        }

    }
}
