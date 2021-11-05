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
    public partial class Matrix2 : Form
    {
        public float[,] num2_m2 = new float[3, 3]; 
        public float[,] num_m2 = new float[3, 3];
        public Matrix2()
        {
            InitializeComponent();
            this.Text = "Matrix2";
        }

        private void m1_8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Matrix2_Load(object sender, EventArgs e)
        {
            
        }

        private void submit_F2_Click(object sender, EventArgs e)
        {
            num_m2[0, 0] = float.Parse(m2_1.Text);
            num_m2[0, 1] = float.Parse(m2_2.Text);
            num_m2[0, 2] = float.Parse(m2_3.Text);

            num_m2[1, 0] = float.Parse(m2_4.Text);
            num_m2[1, 1] = float.Parse(m2_5.Text);
            num_m2[1, 2] = float.Parse(m2_6.Text);

            num_m2[2, 0] = float.Parse(m2_7.Text);
            num_m2[2, 1] = float.Parse(m2_8.Text);
            num_m2[2, 2] = float.Parse(m2_9.Text);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num_m2[i, j] += num2_m2[i, j];
                }
            }
            Result_Form r1 = new Result_Form();
            r1.result = num_m2;
            r1.Show();
            this.Hide();
        }
    }
}
