using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms4
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach ( Control control in Controls)
            {
                Label numberLabel = control as Label;

                if(numberLabel != null)
                {
                    int randomNumber = random.Next(1, 59);
                    numberLabel.Text = randomNumber.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
