using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace Arrays
{
    public partial class Arrays : Form
    {
        public Arrays()
        {
            InitializeComponent();
        }
        private void btnSingleDim_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string input = PromptUser($"Enter Element [{i}]");
                if (!int.TryParse(input, out numbers[i]))
                {
                    MessageBox.Show("Invalid input. Please enter a Number.");
                    return;
                }
            }
            Array.Sort(numbers);
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Sorted Array: " + string.Join(", ", numbers));
        }

        private void btnMultiDim_Click(Object sender, EventArgs e)
        {
            int[,] array = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    string input = PromptUser($"Enter element [{i}], [{j}]");
                    if (!int.TryParse(input, out array[]))
                    {
                        MessageBox.Show("Invalid input. Please enter a Number.");
                        return;

                    }
                }
            }

            lstDisplay.Items.Clear();
            for (int i = 0; i < 2; i++)
            {
                lstDisplay.Items.Add($"{array[i, 0]} {array[i, 1]} ");
            }

        }

        private void btnJaggedArray_Click(Object sender, EventArgs e)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[4];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    string input = PromptUser($"Enter Element [{i}] [{j}]");
                    if (!int.TryParse(input, out jaggedArray[i][j]))
                    {
                        MessageBox.Show("Invalid input. Please enter a number.");
                        return;
                    }
                }
            }
            lstDisplay.Items.Clear();
            foreach (var row in jaggedArray)
            {
                lstDisplay.Items.Add(string.Join(" ", row));
            }


        }

        private string PromptUser(string message)
        {
            using (Form inputForm = new Form())
            {
                inputForm.Text = "Input";
                inputForm.StartPosition = FormStartPosition.CenterParent;
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.ClientSize = new System.Drawing.Size(250, 120);

                Label lbl = new Label() { Left = 10, Top = 10, Text = message, AutoSize = true };
                TextBox inputTextBox = new TextBox() { Left = 10, Top = 30, Width = 200 };
                Button btnOk = new Button() { Text = "OK", Left = 10, Top = 60, Width = 50, DialogResult = DialogResult.OK };

                inputForm.Controls.Add(lbl);
                inputForm.Controls.Add(inputTextBox);
                inputForm.Controls.Add(btnOk);

                inputForm.AcceptButton = btnOk;

                // ShowDialog waits for the user input, and returns the text entered
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return inputTextBox.Text;  // Correct reference to the TextBox
                }
                return string.Empty; // Return empty string if user closes the form
            }
        }

    }


}
}
