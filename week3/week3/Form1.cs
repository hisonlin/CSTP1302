namespace week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int temp = 40;
            if (temp > 40)
            {
                MessageBox.Show("Hot!");
            }
            else
            {
                MessageBox.Show("Cold!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int.TryParse("1", out x);
            MessageBox.Show(x.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}