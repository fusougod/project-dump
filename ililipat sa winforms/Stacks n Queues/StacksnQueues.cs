using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Stacks_n_Queues
{
    public partial class StacksnQueues : Form
    {

        private Stack<int> stack = new Stack<int>();
        private Queue<int> queue = new Queue<int>();
        public StacksnQueues()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int num))
            {

                stack.Push(num);
                UpdateStackDisplay();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Invalid input. Enter a number.");

            }

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                MessageBox.Show("Popped: " + stack.Pop());
                UpdateStackDisplay();
                txtInput.Clear();

            }
            else
            {
                MessageBox.Show("Stack is empty");
            }

        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int num))
            {
                queue.Enqueue(num);
                UpdateQueueDisplay();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Invalid input. Enter a number.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                MessageBox.Show("Dequeued: " + queue.Dequeue());
                UpdateQueueDisplay();
                txtInput.Clear();
            }
            else {
                MessageBox.Show("Queue is empty.");
            }

        }

        private void UpdateStackDisplay()
        {
            lstStack.Items.Clear();
            foreach (var item in stack)
            {
                lstStack.Items.Add(item);
            }
        }

        private void UpdateQueueDisplay()
        {
            lstQueue.Items.Clear();
            foreach (var item in queue)
            {
                lstQueue.Items.Add(item);
            }
        }
    }
}
