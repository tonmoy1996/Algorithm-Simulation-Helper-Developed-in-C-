using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Algorithm
{
    public partial class Main : Form
    {

       public static int limit = 1;

        

        public Main()
        {
            InitializeComponent();
        }

        public void get(string c)
        {
           // this.aa = c;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 s = new Form1();

                limit = Convert.ToInt32(textBox1.Text);
                //s.jj = limit;
                s.Show();
                 this.Hide();
            }

            catch
            {
                textBox1.BackColor = Color.Red;

                MessageBox.Show("Giver the numbers size to sort");


            }

            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }












        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StackAndQueue q = new StackAndQueue();

            q.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            try
            {
                Search s = new Search();

                limit = Convert.ToInt32(textBox1.Text);
               // s.jj = limit;
                s.Show();
                this.Hide();
            }

            catch
            {
                textBox1.BackColor = Color.Red;

                MessageBox.Show("Giver the numbers size to Search");


            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();

            l1.Show();

            this.Hide();
        }
    }
}
