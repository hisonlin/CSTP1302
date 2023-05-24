namespace Lab4
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
            speedLabel = new Label();
            hoursLabel = new Label();
            speedTextBox = new TextBox();
            hoursTextBox = new TextBox();
            listBox1 = new ListBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // speedLabel
            // 
            speedLabel.AutoSize = true;
            speedLabel.Location = new Point(34, 45);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(201, 23);
            speedLabel.TabIndex = 0;
            speedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursLabel
            // 
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new Point(93, 91);
            hoursLabel.Name = "hoursLabel";
            hoursLabel.Size = new Size(142, 23);
            hoursLabel.TabIndex = 1;
            hoursLabel.Text = "Hours Traveled:";
            // 
            // speedTextBox
            // 
            speedTextBox.Location = new Point(241, 42);
            speedTextBox.Name = "speedTextBox";
            speedTextBox.Size = new Size(150, 30);
            speedTextBox.TabIndex = 2;
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(241, 91);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(150, 30);
            hoursTextBox.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(34, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(357, 188);
            listBox1.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(34, 387);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(279, 387);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 34);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 450);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(listBox1);
            Controls.Add(hoursTextBox);
            Controls.Add(speedTextBox);
            Controls.Add(hoursLabel);
            Controls.Add(speedLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label speedLabel;
        private Label hoursLabel;
        private TextBox speedTextBox;
        private TextBox hoursTextBox;
        private ListBox listBox1;
        private Button calculateButton;
        private Button exitButton;
    }
}