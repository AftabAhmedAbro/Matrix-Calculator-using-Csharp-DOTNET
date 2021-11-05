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
    public partial class Result_Form : Form
    {
        public float[,] result = new float[3, 3];

        public Result_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Result_Form_Load(object sender, EventArgs e)
        {
            this.label1.Text = result[0, 0].ToString();
            this.label2.Text = result[0, 1].ToString();
            this.label3.Text = result[0, 2].ToString();
            this.label4.Text = result[1, 0].ToString();
            this.label5.Text = result[1, 1].ToString();
            this.label6.Text = result[1, 2].ToString();
            this.label7.Text = result[2, 0].ToString();
            this.label8.Text = result[2, 1].ToString();
            this.label9.Text = result[2, 2].ToString();
            
        }
    }
}
