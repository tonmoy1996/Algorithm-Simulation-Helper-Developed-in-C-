using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace Algorithm
{
    public partial class Register : Form
    {


        string vri;






        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numbers = "0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < 2; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            for (int i = 2; i < 6; i++)
            {
                stringChars[i] = numbers[random.Next(numbers.Length)];
            }
            for (int i = 6; i < 8; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }








       

        private void button1_Click(object sender, EventArgs e)
        {
           



            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {


                if (textBox1.Text == "")
                {

                    textBox1.BackColor = Color.Red;

                }

                if (textBox2.Text == "")
                {

                    textBox2.BackColor = Color.Red;

                }

                if (textBox3.Text == "")
                {

                    textBox3.BackColor = Color.Red;

                }



            }



            else
            {


userdbDataContext ud = new userdbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Vault\Algorithm\Algorithm\user_info.mdf;Integrated Security=True;Connect Timeout=30");


            person pr = ud.persons.SingleOrDefault((n => n.name == textBox1.Text || n.phone == textBox3.Text));


            if (pr != null)
            {

                MessageBox.Show("Name or email already Exits ,Try another Name");


                textBox1.Text = textBox2.Text = textBox3.Text = null;

                //this.varifi.Visible = false;
            }



            else
            {





                vri = RandomString();



                string your_id = "moukhkst01@gmail.com";
                string your_password = "rememberme11111";
                try
                {
                    SmtpClient client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new System.Net.NetworkCredential(your_id, your_password),
                        Timeout = 10000,
                    };
                    MailMessage mm = new MailMessage(your_id, textBox3.Text, "VARIFICATION EMAIL  ", vri);
                    client.Send(mm);
                    Console.WriteLine("Email Sent");
                    //MessageBox.Show("send");
                    this.varifi.Visible = true;




                }
                catch (Exception ex)
                {
                    MessageBox.Show("ex  :" + ex);
                    Console.WriteLine("Could not end email\n\n" + ex.ToString());
                }



            }

               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Login g = new Login();

            g.Show();

            this.Hide();
        }

        

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void Register_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string s = textBox4.Text.ToString();


           if(vri.Equals(s) ) { 
            userdbDataContext ud = new userdbDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Vault\Algorithm\Algorithm\user_info.mdf;Integrated Security=True;Connect Timeout=30");


            person pr = ud.persons.SingleOrDefault((n => n.name == textBox1.Text || n.phone == textBox3.Text));


            if (pr != null)
            {

                MessageBox.Show("Name or email already Exits ,Try another Name");


                textBox1.Text = textBox2.Text = textBox3.Text = null;

                this.varifi.Visible = false;
            }



            else
            {


           
            
            
            
            
            person p = new person
            {


                name = textBox1.Text,

                phone = textBox3.Text,

                password = textBox2.Text




            };




            ud.persons.InsertOnSubmit(p);
            ud.SubmitChanges();


            MessageBox.Show("Register successfull");


            textBox1.Text = textBox2.Text = textBox3.Text = null;
            }




            Login l = new Login();

            l.Show();

            this.Hide();






            }

           else
           {


               MessageBox.Show("invalid code !!!!!!!!!!!!");



           }
        }

        private void varifi_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
