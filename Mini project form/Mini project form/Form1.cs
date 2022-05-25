using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project_form
{
    public partial class Form1 : Form
    {
       
        private Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

     private void button1_Click(object sender, EventArgs e)
        {
            string Id = "admin";
            string Pin = "1234";

            if(textBox1.Text.Equals(Id) && textBox2.Text.Equals(Pin))
            {
                MessageBox.Show("Welcome To ATM");
            }
            else
            {
                MessageBox.Show("Wrong User or Password");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
