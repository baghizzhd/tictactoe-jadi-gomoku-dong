using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        int[,] arr = new int[3, 3];
        bool x = true; //A
        int t = 0;
        public static int status = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1, label2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t++;


            changeimg(pictureBox2, label2);
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            t++;

            

            changeimg(pictureBox3,label2);
           
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            t++;

            changeimg(pictureBox4, label2);
           
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            t++;

          


            changeimg(pictureBox5, label2);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            t++;




            changeimg(pictureBox6, label2);
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            t++;

            


            changeimg(pictureBox7, label2);


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            t++;

           
            changeimg(pictureBox8, label2);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            t++;

            changeimg(pictureBox9, label2);
           
            
           
        }




        private void changeimg(PictureBox px,Label l)
        {
            if (x==true)
            {
                px.Image = Image.FromFile(@"D:\assigment\tictactoe\tictactoe\Resources\6965728_preview.png");
                x = false;
                l.Text =gameform.name2 ;

            }
            else
            {
                px.Image = Image.FromFile(@"D:\assigment\tictactoe\tictactoe\Resources\circle-xxl.png");
                x = true;
                l.Text = gameform.name;

            }
            px.Enabled = false;

        }


        /*
        private void check()
        {
            int[] row = new int[3];
            int[] col = new int[3];
            int d1=0, d2=0;

            for (int i = 0; i < 3; i++)
            {
                row[i] = 0;
                col[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    row[i] = row[i] + arr[i, j];
                    col[i] = col[i] +arr[j, i];
                    if (i==j)
                    {
                        d1 = d1 + arr[i, j];
                    }

                    if (i+j==2)
                    {
                        d2 = d2 + arr[i, j];
                    }

                }
            
            } //outerloop




            if (d1==3 ||  d2==3)
            {
               //  MessageBox.Show("Player A WON........ ");
                status = 1;
                this.Hide();
                Form2 ob = new Form2();
                ob.Show();

                return;

            }
            else if (d1 == -3 || d2 == -3)
            {
              //  MessageBox.Show("Player B WON........ ");
                status = 2;
                this.Hide();
                Form2 ob = new Form2();
                ob.Show();
                return;

            }
            else
            {

                for (int i = 0; i < 3; i++)
                {
                    if (row[i]==3 || col[i]==3)
                    {
                        // MessageBox.Show("Player A WON........ ");
                        status = 1;
                        this.Hide();
                        Form2 ob = new Form2();
                        ob.Show();
                         return;
                    }
                    else if (row[i] == -3 || col[i] == -3)
                    {
                       // MessageBox.Show("Player B WON........ ");
                        status = 2;
                        this.Hide();
                        Form2 ob = new Form2();
                        ob.Show();
                        return; 
                    }
                }


            }

            if (t==9)
            {
                this.Hide();
                Form2 ob = new Form2();
                ob.Show();
                
            }

        }
       */
    }
}
