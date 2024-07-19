namespace wild_hog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Pressing the controls is meaningless until the user gives a valid
            // file path.
            checkBox1.Enabled = false;
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Momentary hog button should not be available during autohogging.
            if (checkBox1.Checked)
            {
                button1.Enabled = !checkBox1.Checked;
            }

            UpdateHogState(checkBox1.Checked);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateHogState(true);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateHogState(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            m_filePath = textBox1.Text;

            // Pressing the controls is meaningless until the user gives a valid
            // file path, so disable them.  Also, don't hog a file whose path has
            // only just been supplied.
            bool fileExists = File.Exists(m_filePath);
            checkBox1.Enabled = fileExists;
            checkBox1.Checked = false;
            button1.Enabled = fileExists;
            UpdateHogState(false);
        }

        private void UpdateHogState(bool shouldHog)
        {
            if (File.Exists(m_filePath) && shouldHog)
            {
                // Try to start hogging.
                try
                {
                    m_stream = File.Open(m_filePath, FileMode.OpenOrCreate,
                        FileAccess.ReadWrite, FileShare.None);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to open file.");
                    checkBox1.CheckState = CheckState.Unchecked;
                    button1.Enabled = true;
                }
            }
            else if (File.Exists(m_filePath) && !shouldHog)
            {
                // Stop hogging, if necessary.
                if (m_stream != null)
                {
                    m_stream.Close();
                }
            }
        }

        private static string m_filePath = "";
        private static System.IO.FileStream? m_stream;
    }
}
