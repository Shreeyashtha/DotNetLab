using System.Runtime.InteropServices;

namespace FormInheritance
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Simple_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Calculator calculator = new Calculator();
            //calculator.Show();
            if (calculator == null || calculator.IsDisposed)
            {
                this.calculator = new Calculator();
                calculator.Show();
            }
            else
            {
                calculator.Focus();
            }
            //this.calculator = new Calculator();
            //calculator.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label2.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();

            Login loginForm = new Login();
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            panel6.Controls.Add(loginForm);
            loginForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.TopLevel = false;
            regForm.FormBorderStyle = FormBorderStyle.None;
            regForm.Dock = DockStyle.Fill;

            panel6.Controls.Add(regForm);
            regForm.Show();
        }
    }
}
