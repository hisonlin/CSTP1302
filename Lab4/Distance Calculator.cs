namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Clear the list box
            listBox1.Items.Clear();

            // Get the user input
            if (int.TryParse(speedTextBox.Text, out int speed) && int.TryParse(hoursTextBox.Text, out int hours))
            {
                // Calculate and display the distance for each hour
                for (int hour = 1; hour <= hours; hour++)
                {
                    int distance = speed * hour;
                    listBox1.Items.Add($"After hour {hour} the distance is {distance}.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid speed and hours.");
            }
        }
    }
}