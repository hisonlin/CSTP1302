namespace Lab4_Q3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean lightON = true;


        private void button1_Click(object sender, EventArgs e)
        {
            lightON = !lightON;
            switchLight();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            switchLight();

        }

        private void switchLight()
        {

            if (lightON)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label1.Text = "ON";
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label1.Text = "OFF";
            }
        }
    }
}