﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading.Tasks;


namespace Algorithm
{
    public partial class StackAndQueue : Form
    {
         Stack<String> stack = new Stack<String>();
        Queue<String> queue = new Queue<String>();
        List<String> list = new List<String>();




        public StackAndQueue()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtElement.Text))
            {
                MessageBox.Show("Enter Value");
                txtElement.Clear();
                txtElement.Focus();
            }
            else
            {

                String add;
                add = txtElement.Text;
                stack.Push(add);

                txtElement.Clear();
                txtElement.Focus();
                StackListBox.Items.Clear();
                foreach (String s in stack)
                {
                    StackListBox.Items.Add((Environment.NewLine + s.ToString()));
                    
                }
            }    
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                StackListBox.Items.Clear();
                foreach (String s in stack)
                {
                    StackListBox.Items.Add((Environment.NewLine + s.ToString()));
                }
            }
            else
                MessageBox.Show("Empty Stack");



        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                var element = stack.Peek();
                MessageBox.Show("Element at the top of stack is  " + element.ToString());
            }
            else
                MessageBox.Show("Empty Stack");



        }

        private void btnSize_Click(object sender, EventArgs e)
        {

            var element = stack.Count();


            MessageBox.Show("Number of Element is: " + element.ToString());


        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {

            String add;
            if (String.IsNullOrEmpty(textElement1.Text))
            {
                MessageBox.Show("Enter values");
                textElement1.Clear();
                textElement1.Focus();
            }
            else
            {
                add = textElement1.Text;
                queue.Enqueue(add);
                textElement1.Clear();
                textElement1.Focus();
            }
            QueueListBox.Items.Clear();
            foreach (String q in queue)
            {
                QueueListBox.Items.Add((Environment.NewLine + q.ToString()));
            }




        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {

            if (queue.Count == 0)
            {
                MessageBox.Show("Queue is empty");
            }
            else
            {
                queue.Dequeue();
                QueueListBox.Items.Clear();
                foreach (String q in queue)
                {
                    QueueListBox.Items.Add((Environment.NewLine + q.ToString()));
                }
            }


        }

        private void btnQsize_Click(object sender, EventArgs e)
        {
            var size = queue.Count();
            MessageBox.Show("Number of Elements in the queue is " + size.ToString());


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StackAndQueue_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Main m = new Main();

            m.Show();

            this.Hide();
        }

      



        }

}
 