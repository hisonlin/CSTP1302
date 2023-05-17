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
            additionButton = new Button();
            subtractionButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            operand1TextBox = new TextBox();
            operand2TextBox = new TextBox();
            resultTextBox = new TextBox();
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
            // additionButton
            // 
            additionButton.Location = new Point(311, 205);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(46, 23);
            additionButton.TabIndex = 1;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = true;
            additionButton.Click += additionButton_Click;
            // 
            // subtractionButton
            // 
            subtractionButton.Location = new Point(376, 205);
            subtractionButton.Name = "subtractionButton";
            subtractionButton.Size = new Size(46, 23);
            subtractionButton.TabIndex = 2;
            subtractionButton.Text = "-";
            subtractionButton.UseVisualStyleBackColor = true;
            subtractionButton.Click += subtractionButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Location = new Point(441, 205);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(46, 23);
            multiplicationButton.TabIndex = 3;
            multiplicationButton.Text = "*";
            multiplicationButton.UseVisualStyleBackColor = true;
            multiplicationButton.Click += multiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Location = new Point(506, 205);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(46, 23);
            divisionButton.TabIndex = 4;
            divisionButton.Text = "/";
            divisionButton.UseVisualStyleBackColor = true;
            divisionButton.Click += divisionButton_Click;
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
            resultTextBox.Location = new Point(311, 62);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(241, 23);
            resultTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(operand2TextBox);
            Controls.Add(operand1TextBox);
            Controls.Add(divisionButton);
            Controls.Add(multiplicationButton);
            Controls.Add(subtractionButton);
            Controls.Add(additionButton);
            Controls.Add(resultHistoryListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox resultHistoryListBox;
        private Button additionButton;
        private Button subtractionButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private TextBox operand1TextBox;
        private TextBox operand2TextBox;
        private TextBox resultTextBox;
    }
}