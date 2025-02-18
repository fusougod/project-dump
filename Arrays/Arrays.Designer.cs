namespace Arrays
{
    partial class Arrays
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
            txtInput = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // btnSingleDim
            // 
            btnSingleDim.Location = new Point(12, 55);
            btnSingleDim.Name = "btnSingleDim";
            btnSingleDim.Size = new Size(143, 53);
            btnSingleDim.TabIndex = 0;
            btnSingleDim.Text = "Single Dimension";
            btnSingleDim.UseVisualStyleBackColor = true;
            btnSingleDim.Click += btnSingleDim_Click;
            // 
            // btnMultiDim
            // 
            btnMultiDim.Location = new Point(12, 114);
            btnMultiDim.Name = "btnMultiDim";
            btnMultiDim.Size = new Size(143, 53);
            btnMultiDim.TabIndex = 1;
            btnMultiDim.Text = "Multi Dimension";
            btnMultiDim.UseVisualStyleBackColor = true;
            btnMultiDim.Click += btnMultiDim_Click;
            // 
            // btnJaggedArray
            // 
            btnJaggedArray.Location = new Point(447, 84);
            btnJaggedArray.Name = "btnJaggedArray";
            btnJaggedArray.Size = new Size(143, 53);
            btnJaggedArray.TabIndex = 2;
            btnJaggedArray.Text = "Jagged Array";
            btnJaggedArray.UseVisualStyleBackColor = true;
            // 
            // lstDisplay
            // 
            lstDisplay.FormattingEnabled = true;
            lstDisplay.ItemHeight = 15;
            lstDisplay.Location = new Point(161, 55);
            lstDisplay.Name = "lstDisplay";
            lstDisplay.Size = new Size(263, 379);
            lstDisplay.TabIndex = 4;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(447, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(297, 23);
            txtInput.TabIndex = 5;
            txtInput.TextChanged += this.txtInput_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(601, 84);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(143, 53);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Arrays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtInput);
            Controls.Add(lstDisplay);
            Controls.Add(btnJaggedArray);
            Controls.Add(btnMultiDim);
            Controls.Add(btnSingleDim);
            Name = "Arrays";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSingleDim;
        private Button btnMultiDim;
        private Button btnJaggedArray;
        private ListBox lstDisplay;
        private TextBox txtInput;
        private Button btnSubmit;
    }
}
