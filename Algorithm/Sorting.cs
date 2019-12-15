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
    public partial class Form1 : Form
    {
        Label[] myLabel = new Label[150];     //create label array called ""mylabel"
        TextBox[] mybox = new TextBox[150];   //create textbox array called "mybox"
        int x = 0;      // X cordinate of first textbox in "mybox" array
        int y = 0;      // Y cordinate of first textbox in "mybox" array
        int a = 20;     // X cordinate of first label in "mylabel" array
        int b = 108;    // Y cordinate of first label in "mylabel" array
        int i;          // Initial value of for loops
        int c = 0;      // c==0 - labels are not created  c!=0 - labels are created
        int d = 0;      // count timer 2 ticks
        int k = 0;      // count timer 1 ticks
        int p = 0;      // index of the label which is going to move with minimum index label
        int n = 0;      // keep track of sorting times
        int length;     // length between label[p] and label[min]
        int j = 1;
       public int jj ;

      
        public Form1()
        {

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            jj = Main.limit;


            for (int i = 0; i < jj; i++)
            {
                mybox[i] = new TextBox();
                mybox[i].Location = new Point(x, y);
                mybox[i].Width = 140-(jj*6);
                x = x + mybox[i].Width+2;
                panel2.Controls.Add(mybox[i]);
                mybox[i].Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Selection Sort")
            {
                button1.Enabled = false;
                panel1.Refresh();
                k = 0;
                p = 0;
                n = 0;

                if (chkElement())   //check whether the values has entered correctly
                {
                    if (c != 0)             // check whether the labels has already created
                    {
                        for (i = 0; i < jj; i++)
                        {
                            myLabel[i].Dispose();   // if the labels are created, first destroy thenm
                        }
                    }

                    for (i = 0; i < jj; i++)
                    {
                        myLabel[i] = new Label();  
                       
                       
                        myLabel[i].Text = mybox[i].Text;              //get textbox value to label
                        myLabel[i].Font = new Font(myLabel[i].Font.Name, 14, myLabel[i].Font.Style, myLabel[i].Font.Unit);
                        myLabel[i].Location = new Point(a, b);        //defind the location
                        myLabel[i].Width = 176 - (jj * 10) ;                        // defind the width of label
                        myLabel[i].Height = 176 - (jj * 10); ;                       // defind the height of label
                        myLabel[i].TextAlign = ContentAlignment.MiddleCenter; // align texts to center
                        myLabel[i].BackColor = Color.White;           // set label colour as white
                        myLabel[i].BorderStyle = BorderStyle.FixedSingle; // set border style

                        a = a + 176 - (jj * 10)+2; ; // increment X cordinate to create next label
                        panel1.Controls.Add(myLabel[i]); //Add label to panel 1

                        myLabel[i].Visible = true;
                    }
                    a = 21-jj; // set the value of 'a' to its initial value
                    c++;    // now the labels has created
                    timer1.Start();     //start timer 1
                }

            }
            else if ((string)comboBox1.SelectedItem == "Insertion Sort")
            {
                button1.Enabled = false;
                panel1.Refresh();
                k = 1;
                n = 1;
                j = 0;

                if (chkElement())   
                {
                    if (c != 0)             
                    {
                        for (i = 0; i < jj; i++)
                        {
                            myLabel[i].Dispose();  
                        }
                    }

                    for (i = 0; i < jj; i++)
                    {
                        myLabel[i] = new Label();
                        myLabel[i].Font = new Font(myLabel[i].Font.Name, 14, myLabel[i].Font.Style, myLabel[i].Font.Unit);
                        myLabel[i].Text = mybox[i].Text;              
                        myLabel[i].Location = new Point(a, b);
                        myLabel[i].Width = 176 - (jj * 10);
                        myLabel[i].Height = 176 - (jj * 10);                       
                        myLabel[i].TextAlign = ContentAlignment.MiddleCenter;
                        myLabel[i].BackColor = Color.White;           
                        myLabel[i].BorderStyle = BorderStyle.FixedSingle;
                        a = a + 176 - (jj * 10) + 2; 
                        panel1.Controls.Add(myLabel[i]); 

                        myLabel[i].Visible = true;
                    }
                    a = 20; 
                    c++;    
                    timer3.Start();     
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            button1.Enabled = true;
            x = 0;
            y = 0;
            a = 20;
            b = 108;
            d = 0;
            k = 0;
            p = 0;
            n = 0;
            j = 1;
            if (c != 0)
            {
                for (i = 0; i < jj; i++)
                {
                    myLabel[i].Dispose();   // if the labels are created, first destroy thenm
                }
            }

            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k == n)
            {
                myLabel[k].BackColor = Color.Orange;
                k++;
            }
            else if (k <= jj-1)
            {
                myLabel[k - 1].BackColor = Color.Green;
                myLabel[k].BackColor = Color.Orange;
                k++;
            }
            else if (k == jj)
            {
                myLabel[k - 1].BackColor = Color.Green;
                myLabel[minIndex()].BackColor = Color.Red;
                k++;
            }
            else if (n == jj+1)
            {
                timer1.Stop();
            }
            else
            {
                k = 0;
                timer1.Stop();
                timer2.Start();

            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int aa, bb, cc, dd;
            if (d == 0)
            {
                length = myLabel[minIndex()].Location.X - myLabel[p].Location.X;
            }
            if (d < 100)
            {
                aa = myLabel[minIndex()].Location.X;
                bb = myLabel[minIndex()].Location.Y;
                cc = myLabel[p].Location.X;
                dd = myLabel[p].Location.Y;

                if (length == 0)
                {
                    Point qqq = new Point(cc, dd - 1);
                    myLabel[p].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb - 1);
                    myLabel[minIndex()].Location = pp;

                    Point qq = new Point(cc, dd + 1);
                    myLabel[p].Location = qq;
                }


                d++;
            }
            else if (d < length + 100)
            {
                aa = myLabel[minIndex()].Location.X;
                bb = myLabel[minIndex()].Location.Y;
                cc = myLabel[p].Location.X;
                dd = myLabel[p].Location.Y;

                if (length == 0)
                {

                }
                else
                {
                    Point pp = new Point(aa - 1, bb);
                    myLabel[minIndex()].Location = pp;

                    Point qq = new Point(cc + 1, dd);
                    myLabel[p].Location = qq;
                }


                d++;
            }
            else if (d < length + 200)
            {
                aa = myLabel[minIndex()].Location.X;
                bb = myLabel[minIndex()].Location.Y;



                cc = myLabel[p].Location.X;
                dd = myLabel[p].Location.Y;

                if (length == 0)
                {
                    Point qqq = new Point(cc, dd + 1);
                    myLabel[p].Location = qqq;
                }
                else
                {
                    Point pp = new Point(aa, bb + 1);
                    myLabel[minIndex()].Location = pp;

                    Point qq = new Point(cc, dd - 1);
                    myLabel[p].Location = qq;
                }


                d++;
            }
            else
            {
                d = 0;
                Label temp = myLabel[minIndex()];
                myLabel[minIndex()] = myLabel[p];
                myLabel[p] = temp;
                n++;
                k = n;
                p++;
                timer2.Stop();
                myLabel[p - 1].BackColor = Color.CornflowerBlue;

                if (k == jj)
                {
                    button1.Enabled = true;
                    MessageBox.Show("Sorting is Completed !!",
                    "Successfull",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);



                    for(int i = 0 ; i < jj ;i++)
                    {

                        myLabel[i].BackColor = Color.Blue;


                    }
                }
                else
                {
                    timer1.Start();
                }


            }
        }

        public int minIndex()
        {


            int min = n;

            for (int j = n; j < jj; j++)
            {
                for (i = j + 1; i < jj; i++)
                {
                    if (Convert.ToInt32(myLabel[i].Text) < Convert.ToInt32(myLabel[min].Text))
                        min = i;
                }
            }



            return min;
        }

        public bool chkElement()
        {

            try
            {

                for (i = 1; i < jj; i++)
                {
                    int chk = Convert.ToInt32(mybox[i].Text);
                }
                return true;
            }

            catch
            {
                MessageBox.Show("Pease Check Inputs !!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
                button1.Enabled = true;
                return false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (j != 0)
            {
                if (k == 1)
                {
                    if (j != jj)
                    {
                        myLabel[j - 1].BackColor = Color.Yellow;
                        k++;
                    }
                    else
                    {
                        k++;
                    }
                }
                else if (k == 2)
                {
                    myLabel[j - 1].BackColor = Color.White;
                    if (j != jj)
                    {
                        myLabel[j].BackColor = Color.Yellow;
                        k++;
                    }
                    else
                    {
                        timer3.Stop();

                        for (i = 0; i < jj; i++)
                        {
                        myLabel[i].BackColor = Color.CornflowerBlue;
                       
                         i++;
                            }
                        button1.Enabled = true;
                        MessageBox.Show("Sorting is Completed !!",
                        "Successfull",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }

                }
                else if (Convert.ToInt32(myLabel[j - 1].Text) > Convert.ToInt32(myLabel[j].Text))
                {
                    k = 1;
                    myLabel[j].BackColor = Color.Red;
                    timer3.Stop();
                    timer4.Start();
                }

                else
                {
                    if (j == jj-1)
                    {
                        timer3.Stop();
                        for (i = 0; i < jj; i++)
                        {
                            myLabel[i].BackColor = Color.CornflowerBlue;

                            i++;
                        }
                        button1.Enabled = true;
                        MessageBox.Show("Sorting is Completed !!",
                        "Successfull",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        k = 1;
                        timer3.Stop();
                        j++;
                        timer3.Start();
                    }
                }
            }
            else
            {

                k = 1;
                j = n;
                n++;
                myLabel[0].BackColor = Color.White;
                timer3.Stop();
                timer3.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (d < 176 - (jj * 10)+2)
            {
                int aa = myLabel[j].Location.X;
                int bb = myLabel[j - 1].Location.X;
                int cc = myLabel[j].Location.Y;
                int dd = myLabel[j - 1].Location.Y;

                Point pp = new Point(aa - 1, cc);
                myLabel[j].Location = pp;

                Point qq = new Point(bb + 1, dd);
                myLabel[j - 1].Location = qq;

                d++;
            }
            else
            {
                timer4.Stop();
                d = 0;
                Label temp = myLabel[j - 1];
                myLabel[j - 1] = myLabel[j];
                myLabel[j] = temp;
                j--;
                timer3.Start();
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random(); 

            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = r.Next(01,100).ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = jj;
            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = k.ToString();
                k--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = 1;
            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = k.ToString();
                k++;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main m = new Main();

            m.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
