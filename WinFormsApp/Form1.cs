namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Resetting");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Submitting");
        }
    }
}
