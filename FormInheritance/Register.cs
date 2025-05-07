namespace FormInheritance
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = comboBox1.SelectedItem.ToString();
            string[] bagmati = { "kathmandu", "bhaktapur", "lalitpur" };
            string[] gandaki = { "pokhara", "gorkha", "lamjhung" };

            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmati);
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandaki);
                    break;
                default:
                    comboBox2.Items.Add("no district available");
                    break;
            }
        }
    }
}
