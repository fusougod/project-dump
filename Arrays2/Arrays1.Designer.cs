namespace Arrays2
{
    partial class Arrays1
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
            btnSingleDim = new Button();
            btnMultiDim = new Button();
            btnJaggedArray = new Button();
            lstDisplay = new ListBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnSingleDim
            // 
            btnSingleDim.Location = new Point(0, 79);
            btnSingleDim.Name = "btnSingleDim";
            btnSingleDim.Size = new Size(109, 52);
            btnSingleDim.TabIndex = 0;
            btnSingleDim.Text = "Single Dimension";
            btnSingleDim.UseVisualStyleBackColor = true;
            btnSingleDim.Click += btnSingleDim_Click;
            // 
            // btnMultiDim
            // 
            btnMultiDim.Location = new Point(0, 137);
            btnMultiDim.Name = "btnMultiDim";
            btnMultiDim.Size = new Size(109, 52);
            btnMultiDim.TabIndex = 1;
            btnMultiDim.Text = "Multi Dimension";
            btnMultiDim.UseVisualStyleBackColor = true;
            btnMultiDim.Click += btnMultiDim_Click;
            // 
            // btnJaggedArray
            // 
            btnJaggedArray.Location = new Point(0, 195);
            btnJaggedArray.Name = "btnJaggedArray";
            btnJaggedArray.Size = new Size(109, 52);
            btnJaggedArray.TabIndex = 2;
            btnJaggedArray.Text = "Jagged Array";
            btnJaggedArray.UseVisualStyleBackColor = true;
            btnJaggedArray.Click += btnJaggedArray_Click;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.ItemHeight = 15;
            lstDisplay.Location = new Point(129, 79);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(271, 349);
            lstDisplay.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(129, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 15);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "label1";
            // 
            // Arrays1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lstDisplay);
            Controls.Add(btnJaggedArray);
            Controls.Add(btnMultiDim);
            Controls.Add(btnSingleDim);
            Name = "Arrays1";
            Text = "Arrays";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSingleDim;
        private Button btnMultiDim;
        private Button btnJaggedArray;
        private ListBox lstDisplay;
        private Label lblTitle;
    }
}
