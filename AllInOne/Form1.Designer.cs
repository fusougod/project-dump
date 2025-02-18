namespace AllInOne
{
    partial class MainMenu
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(623, 59);
            label1.TabIndex = 0;
            label1.Text = "All in One Project Manager (C#)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(228, 68);
            label2.Name = "label2";
            label2.Size = new Size(304, 37);
            label2.TabIndex = 1;
            label2.Text = "Select a project to open:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 137);
            button1.Name = "button1";
            button1.Size = new Size(167, 65);
            button1.TabIndex = 2;
            button1.Text = "btnCalculator";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(185, 137);
            button2.Name = "button2";
            button2.Size = new Size(167, 65);
            button2.TabIndex = 3;
            button2.Text = "btnDiceRoller";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(358, 137);
            button3.Name = "button3";
            button3.Size = new Size(167, 65);
            button3.TabIndex = 4;
            button3.Text = "btnLibraryManagement";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(531, 137);
            button4.Name = "button4";
            button4.Size = new Size(167, 65);
            button4.TabIndex = 5;
            button4.Text = "btnGradeCalculator";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 371);
            button5.Name = "button5";
            button5.Size = new Size(113, 44);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(704, 137);
            button6.Name = "button6";
            button6.Size = new Size(167, 65);
            button6.TabIndex = 7;
            button6.Text = "btnGradeCalculator";
            button6.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 537);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
