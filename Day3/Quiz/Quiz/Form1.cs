using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        bool q1Correct = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 60;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                //update and display the time left
                timeLeft--;
                labelTimeLeft.Text = timeLeft + "seconds";
            }
            else
            {
                //if the user runs out of time
                timer1.Stop();
                labelTimeLeft.Text = "Time`s up!";
                MessageBox.Show("You ran out of time.", "sorry");
            }
        }

       

        private void radioButtonQ1A1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A1.Checked)
            {
                labelQ1FeedBack.ForeColor = Color.Red;
                labelQ1FeedBack.Text = "\u00fb";//cross
                q1Correct = false;
            }
            else
            {
                labelQ1FeedBack.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A2.Checked)
            {
                labelQ1FeedBack.ForeColor = Color.Green;
                labelQ1FeedBack.Text = "\u00fc";//cross
                q1Correct = true;
            }
            else
            {
                labelQ1FeedBack.Text = "";
            }
        }

      

        
    }
}
