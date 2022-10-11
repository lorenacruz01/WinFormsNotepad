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
    public partial class frmMain : Form
    {
        private string FilePath = "";
        private string FileContent = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxNotePad_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files|*txt";
            openFileDialog.Title = "Open text file";

            openFileDialog.ShowDialog();

            FilePath = openFileDialog.FileName;
            if (FilePath != "")
            {
                txtBoxNotePad.Text = File.ReadAllText(FilePath);
            }
            FileContent = txtBoxNotePad.Text;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
                File.WriteAllText(FilePath, txtBoxNotePad.Text);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileContent = txtBoxNotePad.Text;
            string content = FileContent.ToLower();
            txtBoxNotePad.Text = content;
        }

        private void txtBoxNotePad_TextChanged(object sender, EventArgs e)
        {
           LineCounter();
        }

        private void capitalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileContent = txtBoxNotePad.Text;
            string content = FileContent;
            for (int i = 0; i < content.Length; i++)
            {
                if (i == 0 && content[0].ToString().All(char.IsLower))
                {
                    content = content[0].ToString().ToUpper() + content.Substring(1);
                }

                if(i != 0 && content[i-1] == '\n' && content[i].ToString().All(char.IsLower))
                {
                    content = content.Substring(0,i) + content[i].ToString().ToUpper() + content.Substring(i+1);
                } 
                
                if(i != 0 && content[i - 1] != '\n' && content[i].ToString().All(char.IsUpper))
                {
                    content = content.Substring(0, i) + content[i].ToString().ToLower() + content.Substring(i + 1);
                }

            }
            
            txtBoxNotePad.Text = content;
        }

        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileContent = txtBoxNotePad.Text;
            string content = FileContent.ToUpper();
            txtBoxNotePad.Text = content;
        }



        private void undoPreviousActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxNotePad.Text = FileContent;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Text files|*txt";
            saveFileDialog.Title = "Save file as";
            saveFileDialog.ShowDialog();
            FilePath = saveFileDialog.FileName;
            if (!saveFileDialog.FileName.EndsWith(".txt"))
            {
                FilePath = FilePath + ".txt";
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrEmpty(txtBoxNotePad.Text) && txtBoxNotePad.Text != FileContent)
                {
                    string content = txtBoxNotePad.Text;
                    frmSave frmSaveChanges = new frmSave(FilePath, content);
                    frmSaveChanges.ShowDialog();
                    FilePath = frmSaveChanges.FilePath;
                    txtBoxNotePad.Text = frmSaveChanges.Content;
                } else
                {
                    FilePath = "";
                    txtBoxNotePad.Clear();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContact newFrmContact = new frmContact();
            newFrmContact.ShowDialog();
        }

        private void autoBreakLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(autoBreakLinesToolStripMenuItem.Checked == true)
            {
                txtBoxNotePad.WordWrap = true;
                txtBoxNotePad.ScrollBars = ScrollBars.Vertical;
            } else
            {
                txtBoxNotePad.WordWrap = false;
                txtBoxNotePad.ScrollBars = ScrollBars.Both;
                
            }
            LineCounter();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = txtBoxNotePad.Font;
            fontDialog.ShowDialog();
            txtBoxNotePad.Font = fontDialog.Font;
        }
        public void LineCounter()
        {
            if (showLineNumberToolStripMenuItem1.Checked == true)
            {
                lblNumberOfLines.AutoScrollOffset = new Point(lblNumberOfLines.Location.X, lblNumberOfLines.Location.X);
                lblNumberOfLines.Text = "";
                
                string lineNumbers = "";
                
                if (string.IsNullOrEmpty(txtBoxNotePad.Text))
                {
                    lineNumbers = "1\n";
                }
                else
                {
                    int totalLines;
                    int currentLength;
                    int currentNumberOfLines;
                    int previousLength = 0;
                    int previousLine = 0;
                    totalLines = txtBoxNotePad.Lines.Count();
                    for (int i = 0; i < totalLines; i++)
                    {
                        lineNumbers = lineNumbers + (i + 1).ToString() + '\n';

                        if (i + 1 != totalLines)
                        {
                            currentLength = txtBoxNotePad.Lines[i].Length + 2;
                        }
                        else
                        {
                            currentLength = txtBoxNotePad.Lines[i].Length;
                        }

                        currentNumberOfLines = txtBoxNotePad.GetLineFromCharIndex(currentLength + previousLength);
                        for (int j = previousLine; j < currentNumberOfLines - 1; j++)
                        {
                            lineNumbers = lineNumbers + '\n';
                        }
                        previousLength = previousLength + currentLength;
                        previousLine = currentNumberOfLines;
                    }
                }

                lblNumberOfLines.Text = lineNumbers;
            }
            else
            {
                lblNumberOfLines.Text = "";
            }
            
        }
        private void showLineNumberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
             LineCounter();
            
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
           // LineCounter();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //LineCounter();
        }

        private void txtBoxNotePad_SizeChanged(object sender, EventArgs e)
        {
            LineCounter();
        }
    }
}
