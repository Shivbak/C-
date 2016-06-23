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
        bool q2Correct = false;
        bool q3Correct = false; 
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            labelQ1FeedBack.Visible = false;
            labelQ2feedback.Visible = false;
            labelQ3feedback.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            labelQ1FeedBack.Visible = true;
            labelQ2feedback.Visible = true;
            labelQ3feedback.Visible = true;

            timeLeft = 60;
            timer1.Start();

            button1.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("You got all the questions right", "Well done");
            }
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
                labelQ1FeedBack.Text = "\u00fc";//right
                q1Correct = true;
            }
            else
            {
                labelQ1FeedBack.Text = "";
            }
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A3.Checked)
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

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                labelQ2feedback.ForeColor = Color.Red;
                labelQ2feedback.Text = "\u00fb";//cross
                q2Correct = false;
            }
            else
            {
                labelQ2feedback.Text = "";
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                labelQ2feedback.ForeColor = Color.Green;
                labelQ2feedback.Text = "\u00fc";//right
                q2Correct = true;
            }
            else
            {
                labelQ2feedback.Text = "";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A3.Checked)
            {
                labelQ2feedback.ForeColor = Color.Red;
                labelQ2feedback.Text = "\u00fb";//cross
                q2Correct = false;
            }
            else
            {
                labelQ2feedback.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A1.Checked)
            {
                labelQ3feedback.ForeColor = Color.Red;
                labelQ3feedback.Text = "\u00fb";//cross
                q3Correct = false;
            }
            else
            {
                labelQ3feedback.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A2.Checked)
            {
                labelQ3feedback.ForeColor = Color.Red;
                labelQ3feedback.Text = "\u00fb";//cross
                q3Correct = false;
            }
            else
            {
                labelQ3feedback.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                labelQ3feedback.ForeColor = Color.Green;
                labelQ3feedback.Text = "\u00fc";//right
                q3Correct = true;
            }
            else
            {
                labelQ3feedback.Text = "";
            }
        }
    }
}
