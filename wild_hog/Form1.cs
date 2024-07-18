namespace wild_hog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Program.should_hog = true;
                button1.Enabled = false;
            }
            else
            {
                Program.should_hog = false;
                button1.Enabled = true;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Program.should_hog = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Program.should_hog = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Program.file_path = textBox1.Text;
            checkBox1.Checked = false;
        }
    }
}
