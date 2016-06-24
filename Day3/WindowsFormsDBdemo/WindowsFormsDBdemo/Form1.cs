using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDBdemo
{
    
    public partial class Form1 : Form
    {
        List<Customer> listCustomer = new List<Customer>();
        int customerListIndex = 0;
        

        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ClientsEntities myEntities = new ClientsEntities())
            {
                var customers = from customer in myEntities.Customers
                                select customer;

                listCustomer = customers.ToList();
                
            }

            DisplayCustomer(customerListIndex);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void DisplayCustomer(int customerId)
        {
                if(listCustomer[customerId] != null)
            {
                textBoxName.Text = listCustomer[customerId].Name;
                textBoxStreet.Text = listCustomer[customerId].Street;
                textBoxCity.Text = listCustomer[customerId].City;
                textBoxPostcode.Text = listCustomer[customerId].Postcode;
                textBoxPhone.Text = listCustomer[customerId].Phone;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //next Record Button
            customerListIndex++;
            
            if(customerListIndex >= listCustomer.Count)
            {
                customerListIndex = 0;
            }

            DisplayCustomer(customerListIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //previous Record button
            customerListIndex--;

            if(customerListIndex < 0)
            {
                customerListIndex = listCustomer.Count - 1;
            }

            DisplayCustomer(customerListIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //add record button

            using (ClientsEntities myEntities = new ClientsEntities())
            {
                Customer addedCustomer = new Customer();

                //get customer data from screen
                addedCustomer.Name = textBoxName.Text;
                addedCustomer.Street = textBoxStreet.Text;
                addedCustomer.City = textBoxCity.Text;
                addedCustomer.Postcode = textBoxPostcode.Text;
                addedCustomer.Phone = textBoxPhone.Text;

                //add new record to database
                myEntities.Customers.Add(addedCustomer);
                myEntities.SaveChanges();
            }
        }
    }
}
