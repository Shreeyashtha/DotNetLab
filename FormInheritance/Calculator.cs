﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInheritance
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = number1 + number2;
            textBox3.Text = result.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = number1 - number2;
            textBox3.Text = result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = number1 * number2;
            textBox3.Text = result.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = number1 / number2;
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
