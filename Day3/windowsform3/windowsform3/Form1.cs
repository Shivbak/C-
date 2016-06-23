using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform3
{
    public partial class dialogs_and_forms : Form
    {
        
        public dialogs_and_forms()
        {
            InitializeComponent();
        }

        private void buttoncolour_Click(object sender, EventArgs e)
        {
            //select the colour from the dialog ONLY if OK is clicked

            if(colorDialog2.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog2.Color;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.txt";
            openFileDialog1.Filter = "Textfiles(*.txt)|*.txt|All files(*.*)|*.*";

            //if the file dialogu opens successfully and the filename
            //entered is longer than 0
            if((openFileDialog1.ShowDialog() == DialogResult.OK) && (openFileDialog1.FileName.Length > 0))
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            //create a new Form2 object
            Form2 nextForm = new Form2();
            //show the new form
            nextForm.Show();
            //hide the current form
            this.Hide();

            //set the previous form to be this form
            FormState.previousPage = this;
        }
    }

    public static class FormState
    {
        public static Form previousPage;
    }
}
