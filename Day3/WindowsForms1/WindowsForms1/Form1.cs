using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        string name = "";
        int years = 0;
        int day = 0;
        string month = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //get name from text box
            name = TextBoxName.Text;
            //get today`s date
            DateTime today = DateTime.Now.Date;
            //get the diffrence in days between today`s date
            //and the date in the date time picker
            TimeSpan ageDays = today - dateTimePicker1.Value;
            //work out age in years
            years = ((int)ageDays.TotalDays) / 365;

            //get the day and month from the datetime picker
            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.ToString("MMMM");

            Message.Text = "Hello" + name + "! You will be " + years + "years old on " + day + " " + month + ".";
            
        }
    }
}
