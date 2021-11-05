using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix_Calculator
{
    public partial class Matrix1 : Form
    {
        float[,] num_m1 = new float[3,3];
        
        public Matrix1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_F1_Click(object sender, EventArgs e)
        {
            
            num_m1[0,0] = float.Parse(m1_1.Text);
            num_m1[0, 1] = float.Parse(m1_2.Text);
            num_m1[0, 2] = float.Parse(m1_3.Text);

            num_m1[1, 0] = float.Parse(m1_4.Text);
            num_m1[1, 1] = float.Parse(m1_5.Text);
            num_m1[1, 2] = float.Parse(m1_6.Text);

            num_m1[2, 0] = float.Parse(m1_7.Text);
            num_m1[2, 1] = float.Parse(m1_8.Text);
            num_m1[2, 2] = float.Parse(m1_9.Text);

            Matrix2 m2 = new Matrix2();
            m2.num2_m2 = num_m1;
            m2.Show();
            this.Hide();
        }

        private void m1_9_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1_7_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void m1_3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
