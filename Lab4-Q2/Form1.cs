namespace Lab4_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the list box
            listBox1.Items.Clear();

            // Get user input
            if (int.TryParse(textBox1.Text, out int startingNumber) &&
                double.TryParse(textBox2.Text, out double dailyIncrease) &&
                int.TryParse(textBox3.Text, out int days))
            {
                // Perform population calculation for each day
                double population = startingNumber;
                listBox1.Items.Add($"Day \t Approximate Population");
                listBox1.Items.Add($"1 \t {population}"); // Display initial starting number
                for (int day = 2; day <= days; day++) // Start the loop from day 2
                {
                    population += population * (dailyIncrease / 100);
                    listBox1.Items.Add($"{day} \t {population}");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input.");
            }
        }
    }
}