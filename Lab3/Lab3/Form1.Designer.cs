namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultHistoryListBox = new ListBox();
            addition = new Button();
            subtraction = new Button();
            multiplication = new Button();
            division = new Button();
            operand1TextBox = new TextBox();
            operand2TextBox = new TextBox();
            resultTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // resultHistoryListBox
            // 
            resultHistoryListBox.FormattingEnabled = true;
            resultHistoryListBox.ItemHeight = 15;
            resultHistoryListBox.Location = new Point(311, 91);
            resultHistoryListBox.Name = "resultHistoryListBox";
            resultHistoryListBox.Size = new Size(241, 79);
            resultHistoryListBox.TabIndex = 0;
            // 
            // addition
            // 
            addition.Location = new Point(311, 205);
            addition.Name = "addition";
            addition.Size = new Size(46, 23);
            addition.TabIndex = 1;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = true;
            addition.Click += addition_Click;
            // 
            // subtraction
            // 
            subtraction.Location = new Point(376, 205);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(46, 23);
            subtraction.TabIndex = 2;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = true;
            subtraction.Click += subtraction_Click;
            // 
            // multiplication
            // 
            multiplication.Location = new Point(441, 205);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(46, 23);
            multiplication.TabIndex = 3;
            multiplication.Text = "*";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += multiplication_Click;
            // 
            // division
            // 
            division.Location = new Point(506, 205);
            division.Name = "division";
            division.Size = new Size(46, 23);
            division.TabIndex = 4;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // operand1TextBox
            // 
            operand1TextBox.Location = new Point(311, 176);
            operand1TextBox.Name = "operand1TextBox";
            operand1TextBox.Size = new Size(100, 23);
            operand1TextBox.TabIndex = 5;
            // 
            // operand2TextBox
            // 
            operand2TextBox.Location = new Point(452, 176);
            operand2TextBox.Name = "operand2TextBox";
            operand2TextBox.Size = new Size(100, 23);
            operand2TextBox.TabIndex = 6;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(311, 47);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(241, 23);
            resultTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "Result:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 73);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 9;
            label2.Text = "History:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultTextBox);
            Controls.Add(operand2TextBox);
            Controls.Add(operand1TextBox);
            Controls.Add(division);
            Controls.Add(multiplication);
            Controls.Add(subtraction);
            Controls.Add(addition);
            Controls.Add(resultHistoryListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox resultHistoryListBox;
        private Button addition;
        private Button subtraction;
        private Button multiplication;
        private Button division;
        private TextBox operand1TextBox;
        private TextBox operand2TextBox;
        private TextBox resultTextBox;
        private Label label1;
        private Label label2;
    }
}