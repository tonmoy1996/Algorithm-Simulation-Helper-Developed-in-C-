using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
            userdbDataContext ud = new userdbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Vault\Algorithm\Algorithm\user_info.mdf;Integrated Security=True;Connect Timeout=30");


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.Green;
                }


                if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.Green;
                }

            }

            else
            {


                person pr = ud.persons.SingleOrDefault((n => n.name == textBox1.Text && n.password == textBox2.Text));




                if (pr != null)
                {

                  //  MessageBox.Show("Account is valid");


                    Main2 m = new Main2();
                    m.get(textBox1.Text);

                    m.Show();

                    this.Hide();

                }

                else
                {

                    MessageBox.Show("Account is not valid");


                }


            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Register rs = new Register();

            rs.Show();

            this.Hide();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
