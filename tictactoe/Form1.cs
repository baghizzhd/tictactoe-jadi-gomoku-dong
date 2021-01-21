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
        private void changeimg(PictureBox px, Label l)
        {
            if (x == true)
            {
                px.Image = Image.FromFile(@"D:\assigment\tictactoe\tictactoe\Resources\6965728_preview.png");
                x = false;
                l.Text = gameform.name2;

            }
            else
            {
                px.Image = Image.FromFile(@"D:\assigment\tictactoe\tictactoe\Resources\circle-xxl.png");
                x = true;
                l.Text = gameform.name;

            }
            px.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_0, label2);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t++;


            changeimg(pictureBox0_1, label2);
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            t++;

            

            changeimg(pictureBox0_2,label2);
           
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            t++;

            changeimg(pictureBox0_3, label2);
           
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_4, label2);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_5, label2);    
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_6, label2);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            t++; 
            changeimg(pictureBox0_7, label2);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            t++;

            changeimg(pictureBox0_8, label2);
        }


        private void pictureBox0_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_9, label2);
        }

        private void pictureBox0_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_10, label2);
        }

        private void pictureBox0_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_11, label2);
        }

        private void pictureBox0_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_12, label2);
        }

        private void pictureBox0_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_13, label2);
        }

        private void pictureBox0_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_14, label2);
        }

        private void pictureBox1_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_0, label2);
        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_1, label2);
        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_2, label2);
        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_3, label2);
        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_4, label2);
        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_5, label2);
        }

        private void pictureBox1_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_6, label2);
        }

        private void pictureBox1_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_7, label2);
        }

        private void pictureBox1_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_8, label2);
        }

        private void pictureBox1_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_9, label2);
        }

        private void pictureBox1_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_10, label2);
        }

        private void pictureBox1_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_11, label2);
        }

        private void pictureBox1_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_12, label2);
        }

        private void pictureBox1_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_13, label2);
        }

        private void pictureBox1_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_14, label2);
        }

        private void pictureBox2_0_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox2_0, label2);
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_1, label2);
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_2, label2);
        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_3, label2);
        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_4, label2);
        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_5, label2);
        }

        private void pictureBox2_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_6, label2);
        }

        private void pictureBox2_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_7, label2);
        }

        private void pictureBox2_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_8, label2);
        }

        private void pictureBox2_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_9, label2);
        }

        private void pictureBox2_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_10, label2);
        }

        private void pictureBox2_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_11, label2);
        }

        private void pictureBox2_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_12, label2);
        }

        private void pictureBox2_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_13, label2);
        }

        private void pictureBox2_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_14, label2);
        }

        private void pictureBox3_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_0, label2);
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_1, label2);
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_2, label2);
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_3, label2);
        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_4, label2);
        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_5, label2);
        }

        private void pictureBox3_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_6, label2);
        }

        private void pictureBox3_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_7, label2);
        }

        private void pictureBox3_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_8, label2);
        }

        private void pictureBox3_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_9, label2);
        }

        private void pictureBox3_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_10, label2);
        }

        private void pictureBox3_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_11, label2);
        }

        private void pictureBox3_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_12, label2);
        }

        private void pictureBox3_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_13, label2);
        }

        private void pictureBox3_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_14, label2);
        }

        private void pictureBox4_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_0, label2);
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_1, label2);
        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_2, label2);
        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_3, label2);
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_4, label2);
        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_5, label2);
        }

        private void pictureBox4_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_6, label2);
        }

        private void pictureBox4_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_7, label2);
        }

        private void pictureBox4_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_8, label2);
        }

        private void pictureBox4_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_9, label2);
        }

        private void pictureBox4_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_10, label2);
        }

        private void pictureBox4_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_11, label2);
        }

        private void pictureBox4_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_12, label2);
        }

        private void pictureBox4_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_13, label2);
        }

        private void pictureBox4_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_14, label2);
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
