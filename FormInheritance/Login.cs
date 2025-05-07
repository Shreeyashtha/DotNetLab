using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInheritance
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string uName = textBox1.Text;
            string passWord = textBox2.Text;
            string uNamePattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

            if(Regex.IsMatch(uName, uNamePattern))
            {
                if(uName == "abc@gmail.com" && passWord == "abc")
                {
                    MessageBox.Show("Login Sucess");
                }
                else
                {
                    MessageBox.Show("please enter the valid username and password");
                }
            }
            else
            {
                MessageBox.Show("the entered email is invalid");
            }
        }
    }
}
