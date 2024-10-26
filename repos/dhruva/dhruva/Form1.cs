namespace dhruva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            if (radioButton1.Checked)
                label7.Text = "congragulations! Mr." + textBox1.Text + "you are now registered";
            else
                label7.Text = "congragulations! Ms." + textBox1.Text + " you are now registered";
        }
    }
}