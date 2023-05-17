namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void division_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void PerformOperation(string operators)
        {
            // Get the operands from the user
            double operand1, operand2;
            if (!double.TryParse(operand1TextBox.Text, out operand1) || !double.TryParse(operand2TextBox.Text, out operand2))
            {
                MessageBox.Show("Please enter valid numbers for both operands.");
                return;
            }

            // Perform the operation
            double result;
            string operationText;
            switch (operators)
            {
                case "+":
                    result = operand1 + operand2;
                    operationText = $"{operand1} + {operand2} = {result}";
                    break;
                case "-":
                    result = operand1 - operand2;
                    operationText = $"{operand1} - {operand2} = {result}";
                    break;
                case "*":
                    result = operand1 * operand2;
                    operationText = $"{operand1} * {operand2} = {result}";
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = operand1 / operand2;
                    operationText = $"{operand1} / {operand2} = {result}";
                    break;
                default:
                    return;
            }
            
            // Add the operation details and result to the history ListBox.
            resultHistoryListBox.Items.Add(operationText);

            // Update the result TextBox
            resultTextBox.Text = operationText;

            // Clear the operands text boxes
            operand1TextBox.Clear();
            operand2TextBox.Clear();
        }

    }
}