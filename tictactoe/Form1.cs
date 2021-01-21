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
        //int[,] arr = new int[3, 3];
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
            changeimg(pictureBox0_0, label2);
            check();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_1, label2);
            check();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_2, label2);
            check();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_3, label2);
            check();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_4, label2);
            check();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_5, label2);
            check();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_6, label2);
            check();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            t++; 
            changeimg(pictureBox0_7, label2);
            check();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_8, label2);
            check();
        }


        private void pictureBox0_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_9, label2);
            check();
        }

        private void pictureBox0_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_10, label2);
            check();
        }

        private void pictureBox0_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_11, label2);
            check();
        }

        private void pictureBox0_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_12, label2);
            check();
        }

        private void pictureBox0_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_13, label2);
            check();
        }

        private void pictureBox0_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox0_14, label2);
            check();
        }

        private void pictureBox1_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_0, label2);
            check();
        }

        private void pictureBox1_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_1, label2);
            check();
        }

        private void pictureBox1_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_2, label2);
            check();
        }

        private void pictureBox1_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_3, label2);
            check();
        }

        private void pictureBox1_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_4, label2);
            check();
        }

        private void pictureBox1_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_5, label2);
            check();
        }

        private void pictureBox1_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_6, label2);
            check();
        }

        private void pictureBox1_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_7, label2);
            check();
        }

        private void pictureBox1_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_8, label2);
            check();
        }

        private void pictureBox1_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_9, label2);
            check();
        }

        private void pictureBox1_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_10, label2);
            check();
        }

        private void pictureBox1_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_11, label2);
            check();
        }

        private void pictureBox1_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_12, label2);
            check();
        }

        private void pictureBox1_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_13, label2);
            check();
        }

        private void pictureBox1_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox1_14, label2);
            check();
        }

        private void pictureBox2_0_Click(object sender, EventArgs e)
        { 
            t++;
            changeimg(pictureBox2_0, label2);
            check();
        }

        private void pictureBox2_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_1, label2);
            check();
        }

        private void pictureBox2_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_2, label2);
            check();
        }

        private void pictureBox2_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_3, label2);
            check();
        }

        private void pictureBox2_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_4, label2);
            check();
        }

        private void pictureBox2_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_5, label2);
            check();
        }

        private void pictureBox2_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_6, label2);
            check();
        }

        private void pictureBox2_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_7, label2);
            check();
        }

        private void pictureBox2_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_8, label2);
            check();
        }

        private void pictureBox2_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_9, label2);
            check();
        }

        private void pictureBox2_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_10, label2);
            check();
        }

        private void pictureBox2_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_11, label2);
            check();
        }

        private void pictureBox2_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_12, label2);
            check();
        }

        private void pictureBox2_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_13, label2);
            check();
        }

        private void pictureBox2_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox2_14, label2);
            check();
        }

        private void pictureBox3_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_0, label2);
            check();
        }

        private void pictureBox3_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_1, label2);
            check();
        }

        private void pictureBox3_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_2, label2);
            check();
        }

        private void pictureBox3_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_3, label2);
            check();
        }

        private void pictureBox3_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_4, label2);
            check();
        }

        private void pictureBox3_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_5, label2);
            check();
        }

        private void pictureBox3_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_6, label2);
            check();
        }

        private void pictureBox3_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_7, label2);
            check();
        }

        private void pictureBox3_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_8, label2);
            check();
        }

        private void pictureBox3_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_9, label2);
            check();
        }

        private void pictureBox3_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_10, label2);
            check();
        }

        private void pictureBox3_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_11, label2);
            check();
        }

        private void pictureBox3_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_12, label2);
            check();
        }

        private void pictureBox3_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_13, label2);
            check();
        }

        private void pictureBox3_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox3_14, label2);
            check();
        }

        private void pictureBox4_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_0, label2);
            check();
        }

        private void pictureBox4_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_1, label2);
            check();
        }

        private void pictureBox4_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_2, label2);
            check();
        }

        private void pictureBox4_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_3, label2);
            check();
        }

        private void pictureBox4_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_4, label2);
            check();
        }

        private void pictureBox4_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_5, label2);
            check();
        }

        private void pictureBox4_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_6, label2);
            check();
        }

        private void pictureBox4_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_7, label2);
            check();
        }

        private void pictureBox4_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_8, label2);
            check();
        }

        private void pictureBox4_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_9, label2);
            check();
        }

        private void pictureBox4_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_10, label2);
            check();
        }

        private void pictureBox4_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_11, label2);
            check();
        }

        private void pictureBox4_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_12, label2);
            check();
        }

        private void pictureBox4_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_13, label2);
            check();
        }

        private void pictureBox4_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox4_14, label2);
            check();
        }

        private void pictureBox5_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_0, label2);
            check();
        }

        private void pictureBox5_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_1, label2);
            check();
        }

        private void pictureBox5_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_2, label2);
            check();
        }

        private void pictureBox5_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_3, label2);
            check();
        }

        private void pictureBox5_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_4, label2);
            check();
        }

        private void pictureBox5_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_5, label2);
            check();
        }

        private void pictureBox5_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_6, label2);
            check();
        }
       

        private void pictureBox5_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_7, label2);
            check();
        }

        private void pictureBox5_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_8, label2);
            check();
        }

        private void pictureBox5_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_9, label2);
            check();
        }

        private void pictureBox5_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_10, label2);
            check();
        }

        private void pictureBox5_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_11, label2);
            check();
        }

        private void pictureBox5_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_12, label2);
            check();
        }

        private void pictureBox5_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_13, label2);
            check();
        }

        private void pictureBox5_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox5_14, label2);
            check();
        }

        private void pictureBox6_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox6_0, label2);
            check();
        }

        private void pictureBox6_1_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_1, label2);
            check();
        }

        private void pictureBox6_2_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_2, label2);
            check();
        }

        private void pictureBox6_3_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_3, label2);
            check();
        }

        private void pictureBox6_4_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_4, label2);
            check();
        }

        private void pictureBox6_5_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_5, label2);
            check();
        }

        private void pictureBox6_6_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_6, label2);
            check();
        }

        private void pictureBox6_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox6_7, label2);
            check();

        }

        private void pictureBox6_8_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_8, label2);
            check();
        }

        private void pictureBox6_9_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_9, label2);
            check();
        }

        private void pictureBox6_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox6_10, label2);
            check();

        }

        private void pictureBox6_11_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_11, label2);
            check();
        }

        private void pictureBox6_12_Click(object sender, EventArgs e)
        {

            t++;
            changeimg(pictureBox6_12, label2);
            check();
        }

        private void pictureBox6_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox6_13, label2);
            check();
        }

        private void pictureBox6_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox6_14, label2);
            check();
        }

        private void pictureBox7_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_0, label2);
            check();
        }

        private void pictureBox7_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_1, label2);
            check();
        }

        private void pictureBox7_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_2, label2);
            check();
        }

        private void pictureBox7_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_3, label2);
            check();
        }

        private void pictureBox7_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_4, label2);
            check();
        }

        private void pictureBox7_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_5, label2);
            check();
        }

        private void pictureBox7_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_6, label2);
            check();
        }

        private void pictureBox7_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_7, label2);
            check();
        }

        private void pictureBox7_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_8, label2);
            check();
        }

        private void pictureBox7_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_9, label2);
            check();
        }
        private void pictureBox7_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_10, label2);
            check();
        }


        private void pictureBox7_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_11, label2);
            check();
        }

        private void pictureBox7_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_12, label2);
            check();
        }

        private void pictureBox7_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_13, label2);
            check();
        }

        private void pictureBox7_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox7_14, label2);
            check();
        }

        private void pictureBox8_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_0, label2);
            check();
        }

        private void pictureBox8_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_1, label2);
            check();
        }

        private void pictureBox8_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_2, label2);
            check();
        }

        private void pictureBox8_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_3, label2);
            check();
        }

        private void pictureBox8_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_4, label2);
            check();
        }

        private void pictureBox8_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_5, label2);
            check();
        }

        private void pictureBox8_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_6, label2);
            check();
        }

        private void pictureBox8_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_7, label2);
            check();
        }

        private void pictureBox8_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_8, label2);
            check();
        }

        private void pictureBox8_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_9, label2);
            check();
        }

        private void pictureBox8_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_10, label2);
            check();
        }

        private void pictureBox8_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_11, label2);
            check();
        }

        private void pictureBox8_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_12, label2);
            check();
        }

        private void pictureBox8_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_13, label2);
            check();
        }

        private void pictureBox8_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox8_14, label2);
            check();
        }

        private void pictureBox9_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_0, label2);
            check();
        }

        private void pictureBox9_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_1, label2);
            check();
        }

        private void pictureBox9_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_2, label2);
            check();
        }

        private void pictureBox9_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_3, label2);
            check();
        }

        private void pictureBox9_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_4, label2);
            check();
        }

        private void pictureBox9_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_5, label2);
            check();
        }

        private void pictureBox9_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_6, label2);
            check();
        }

        private void pictureBox9_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_7, label2);
            check();
        }

        private void pictureBox9_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_8, label2);
            check();
        }

        private void pictureBox9_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_9, label2);
            check();
        }

        private void pictureBox9_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_10, label2);
            check();
        }

        private void pictureBox9_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_11, label2);
            check();
        }

        private void pictureBox9_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_12, label2);
            check();
        }

        private void pictureBox9_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_13, label2);
            check();
        }

        private void pictureBox9_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox9_14, label2);
            check();
        }

        private void pictureBox10_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_0, label2);
            check();
        }

        private void pictureBox10_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_1, label2);
            check();
        }

        private void pictureBox10_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_2, label2);
            check();
        }

        private void pictureBox10_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_3, label2);
            check();
        }

        private void pictureBox10_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_4, label2);
            check();

        }

        private void pictureBox10_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_5, label2);
            check();
        }

        private void pictureBox10_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_6, label2);
            check();
        }

        private void pictureBox10_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_7, label2);
            check();
        }

        private void pictureBox10_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_8, label2);
            check();
        }

        private void pictureBox10_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_9, label2);
            check();
        }

        private void pictureBox10_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_10, label2);
            check();
        }

        private void pictureBox10_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_11, label2);
            check();
        }

        private void pictureBox10_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_12, label2);
            check();
        }

        private void pictureBox10_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_13, label2);
            check();
        }

        private void pictureBox10_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox10_14, label2);
            check();
        }

        private void pictureBox11_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_0, label2);
            check();
        }

        private void pictureBox11_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_1, label2);
            check();
        }

        private void pictureBox11_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_2, label2);
            check();
        }

        private void pictureBox11_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_3, label2);
            check();
        }

        private void pictureBox11_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_4, label2);
            check();
        }

        private void pictureBox11_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_5, label2);
            check();
        }

        private void pictureBox11_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_6, label2);
            check();
        }

        private void pictureBox11_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_7, label2);
            check();
        }

        private void pictureBox11_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_8, label2);
            check();
        }

        private void pictureBox11_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_9, label2);
            check();
        }

        private void pictureBox11_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_10, label2);
            check();
        }

        private void pictureBox11_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_11, label2);
            check();
        }

        private void pictureBox11_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_12, label2);
            check();
        }

        private void pictureBox11_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_13, label2);
            check();
        }

        private void pictureBox11_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox11_14, label2);
            check();
        }

        private void pictureBox12_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_0, label2);
            check();
        }

        private void pictureBox12_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_1, label2);
            check();
        }

        private void pictureBox12_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_2, label2);
            check();
        }

        private void pictureBox12_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_3, label2);
            check();
        }

        private void pictureBox12_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_4, label2);
            check();
        }

        private void pictureBox12_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_5, label2);
            check();
        }

        private void pictureBox12_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_6, label2);
            check();
        }

        private void pictureBox12_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_7, label2);
            check();
        }

        private void pictureBox12_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_8, label2);
            check();
        }

        private void pictureBox12_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_9, label2);
            check();
        }

        private void pictureBox12_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_10, label2);
            check();
        }

        private void pictureBox12_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_11, label2);
            check();
        }

        private void pictureBox12_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_12, label2);
            check();
        }

        private void pictureBox12_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_13, label2);
            check();
        }

        private void pictureBox12_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox12_14, label2);
            check();
        }

        private void pictureBox13_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_0, label2);
            check();
        }

        private void pictureBox13_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_1, label2);
            check();
        }

        private void pictureBox13_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_2, label2);
            check();
        }

        private void pictureBox13_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_3, label2);
            check();
        }

        private void pictureBox13_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_4, label2);
            check();
        }

        private void pictureBox13_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_5, label2);
            check();
        }

        private void pictureBox13_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_6, label2);
            check();
        }

        private void pictureBox13_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_7, label2);
            check();
        }

        private void pictureBox13_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_8, label2);
            check();
        }

        private void pictureBox13_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_9, label2);
            check();
        }

        private void pictureBox13_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_10, label2);
            check();
        }

        private void pictureBox13_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_11, label2);
            check();
        }

        private void pictureBox13_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_12, label2);
            check();
        }

        private void pictureBox13_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_13, label2);
            check();
        }

        private void pictureBox13_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox13_14, label2);
            check();
        }

        private void pictureBox14_0_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_0, label2);
            check();
        }

        private void pictureBox14_1_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_1, label2);
            check();
        }

        private void pictureBox14_2_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_2, label2);
            check();
        }

        private void pictureBox14_3_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_3, label2);
            check();
        }

        private void pictureBox14_4_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_4, label2);
            check();
        }

        private void pictureBox14_5_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_5, label2);
            check();
        }

        private void pictureBox14_6_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_6, label2);
            check();
        }

        private void pictureBox14_7_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_7, label2);
            check();
        }

        private void pictureBox14_8_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_8, label2);
            check();
        }

        private void pictureBox14_9_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_9, label2);
            check();
        }

        private void pictureBox14_10_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_10, label2);
            check();
        }

        private void pictureBox14_11_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_11, label2);
            check();
        }

        private void pictureBox14_12_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_12, label2);
            check();
        }

        private void pictureBox14_13_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_13, label2);
            check();
        }

        private void pictureBox14_14_Click(object sender, EventArgs e)
        {
            t++;
            changeimg(pictureBox14_14, label2);
            check();
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

        private void check()
        {
            if (t == 225)
            {
                this.Hide();
                Form2 ob = new Form2();
                ob.Show();

            }
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
