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
    public partial class Search : Form
    {
        Label[] myLabel = new Label[150];     //create label array called ""mylabel"
        Label Slabel = new Label();
        TextBox[] mybox = new TextBox[150];   //create textbox array called "mybox"
        int x = 0;      // X cordinate of first textbox in "mybox" array
        int y = 0;      // Y cordinate of first textbox in "mybox" array
        
        int a = 40;     // X cordinate of first label in "mylabel" array
        int a1 = 500;
        int b = 278;    // Y cordinate of first label in "mylabel" array

        int b1 = 40;
        int i;          // Initial value of for loops
        int c = 0;      // c==0 - labels are not created  c!=0 - labels are created
      // // int d = 0;      // count timer 2 ticks
      ////  int k = 0;      // count timer 1 ticks
      //  int p = 0;      // index of the label which is going to move with minimum index label
      //  int n = 0;      // keep track of sorting times
      //  int length;     // length between label[p] and label[min]
        //int j = 1;
        int kj = 0;
        public int jj = 5;


       

       



        public Search()
        {
             
            InitializeComponent();
         //  Load11();
        }

        private void Search_Load(object sender, EventArgs e)
        {

            jj = Main.limit;
            for (int i = 0; i < jj; i++)
            {
                this.mybox[i] = new TextBox();
                this.mybox[i].Location = new Point(x, y);
                this.mybox[i].Width = 140 - (jj * 6);
                x = x + mybox[i].Width + 2;
                this.panel2.Controls.Add(mybox[i]);
                this.mybox[i].Visible = true;



            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            
                button1.Enabled = false;
                panel1.Refresh();
               // k = 0;
                //p = 0;
                //n = 0;

                if (chkElement())   //check whether the values has entered correctly
                {
                    if (c != 0)             // check whether the labels has already created
                    {
                        for (i = 0; i < jj; i++)
                        {
                            myLabel[i].Dispose();   // if the labels are created, first destroy thenm
                        }

                          Slabel.Dispose();
                       
                    }


                    for (i = 0; i < jj; i++)
                    {
                        myLabel[i] = new Label();


                        myLabel[i].Text = mybox[i].Text;              //get textbox value to label
                        myLabel[i].Font = new Font(myLabel[i].Font.Name, 14, myLabel[i].Font.Style, myLabel[i].Font.Unit);
                        myLabel[i].Location = new Point(a, b);        //defind the location
                        myLabel[i].Width = 176 - (jj * 10);                        // defind the width of label
                        myLabel[i].Height = 176 - (jj * 10); ;                       // defind the height of label
                        myLabel[i].TextAlign = ContentAlignment.MiddleCenter; // align texts to center
                        myLabel[i].BackColor = Color.White;           // set label colour as white
                        myLabel[i].BorderStyle = BorderStyle.FixedSingle; // set border style

                        a = a + 176 - (jj * 10) + 2; ; // increment X cordinate to create next label
                        panel1.Controls.Add(myLabel[i]); //Add label to panel 1

                        myLabel[i].Visible = true;
                    }

                     Slabel = new Label();
                    Slabel.Text = tb1.Text;              //get textbox value to label
                    Slabel.Font = new Font(Slabel.Font.Name, 14, Slabel.Font.Style, Slabel.Font.Unit);
                    Slabel.Location = new Point(a1, b1);        //defind the location
                    Slabel.Width = 176 - (jj * 10);                        // defind the width of label
                    Slabel.Height = 176 - (jj * 10); ;                       // defind the height of label
                    Slabel.TextAlign = ContentAlignment.MiddleCenter; // align texts to center
                    Slabel.BackColor = Color.Purple;           // set label colour as white
                    Slabel.BorderStyle = BorderStyle.FixedSingle; // set border style

                    panel1.Controls.Add(Slabel); //Add label to panel 1

                    Slabel.Visible = true;











                    a = 21 - jj; // set the value of 'a' to its initial value
                    c++;    // now the labels has created
                    timer3.Start();     //start timer 1
                }

            
           
        }




        public bool chkElement()
        {

            try
            {

                for (i = 1; i < jj; i++)
                {
                    int chk = Convert.ToInt32(mybox[i].Text);
                }


                int chk1 = Convert.ToInt32(tb1.Text);

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

        private void Search_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Random r = new Random();

            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = r.Next(01, 100).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer3.Stop();
            
            button1.Enabled = true;
             x = 0;     
           y = 0;      
             a = 40;    
             b = 278;
             a1 = 500;
           b1 = 40;
            //p = 0;      
            // n = 0;      
            if (c != 0)
            {
                for (i = 0; i < jj; i++)
                {
                    myLabel[i].Dispose();   // if the labels are created, first destroy thenm
                }

                Slabel.Dispose();
            }

           

            for (int i = 0; i < jj; i++)
            {
                mybox[i].Text = "";
            }

            tb1.Text = "";
            button1.Enabled = true;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            myLabel[kj].BackColor = Color.Green;
             if (Convert.ToInt32(Slabel.Text) == Convert.ToInt32(myLabel[kj].Text))
                {
                   
                    myLabel[kj].BackColor = Color.Red;

                    timer3.Stop(); 
                 
                 MessageBox.Show("value  found.... At  :  " + (kj + 1));

                 kj = 0;
                 button1.Enabled = true;  
                    
                }

                else
                {
                    if (kj == jj - 1)
                    {
                        timer3.Stop();
                        MessageBox.Show("value not found");
                        kj = 0;
                        button1.Enabled = true;
                    }
                    else
                    {
                       
                        timer3.Stop();
                        kj++;
                        timer3.Start();
                    }
                }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            Main m = new Main();

            m.Show();

            this.Hide();
        }

       

       
           
        










}

    }

