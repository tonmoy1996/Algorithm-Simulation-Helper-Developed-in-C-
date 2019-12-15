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
    public partial class Main2 : Form
    {
       
       public static int limit = 0;

       string aa;

       public Main2()
       {

          
           InitializeComponent();
       }

       public void get(string c)
       {
           this.aa = c;
       
       }




        

        

        private void Main2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Main2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            userdbDataContext ud = new userdbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Vault\Algorithm\Algorithm\user_info.mdf;Integrated Security=True;Connect Timeout=30");


            person pr = ud.persons.SingleOrDefault((n => n.name == aa));
            pr.name=textBox2.Text;
            pr.phone = textBox4.Text;
            pr.password=textBox3.Text;


            ud.SubmitChanges();

            MessageBox.Show("Information Update Sucessful");



        }

        private void Main2_Load_1(object sender, EventArgs e)
        {

            userdbDataContext ud = new userdbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Vault\Algorithm\Algorithm\user_info.mdf;Integrated Security=True;Connect Timeout=30");


            var x = from a in ud.persons
                    where a.name == aa
                    select a;


            textBox2.Text = x.FirstOrDefault().name;

            textBox3.Text = x.FirstOrDefault().password;
            textBox4.Text = x.FirstOrDefault().phone;

            //dataGridView1.DataSource = x.ToList();


            // dataGridView1.DataSource = ud.persons;



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();

            l.Show();

            this.Hide();

        }

        private void Main2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
