namespace Stacks_n_Queues
{
    partial class StacksnQueues
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
            txtInput = new TextBox();
            lstStack = new ListBox();
            lstQueue = new ListBox();
            btnPush = new Button();
            btnPop = new Button();
            btnEnqueue = new Button();
            btnDequeue = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(13, 61);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(266, 23);
            txtInput.TabIndex = 0;
            // 
            // lstStack
            // 
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 15;
            lstStack.Location = new Point(285, 61);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(233, 379);
            lstStack.TabIndex = 1;
            // 
            // lstQueue
            // 
            lstQueue.FormattingEnabled = true;
            lstQueue.ItemHeight = 15;
            lstQueue.Location = new Point(538, 61);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(233, 379);
            lstQueue.TabIndex = 2;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(12, 90);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(124, 46);
            btnPush.TabIndex = 3;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(155, 90);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(124, 46);
            btnPop.TabIndex = 4;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(12, 142);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(124, 46);
            btnEnqueue.TabIndex = 5;
            btnEnqueue.Text = "Queue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(155, 142);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(124, 46);
            btnDequeue.TabIndex = 6;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 7;
            label1.Text = "Enter Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 39);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "List of Stack";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 39);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 9;
            label3.Text = "List of Queue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(lstQueue);
            Controls.Add(lstStack);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox lstStack;
        private ListBox lstQueue;
        private Button btnPush;
        private Button btnPop;
        private Button btnEnqueue;
        private Button btnDequeue;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
