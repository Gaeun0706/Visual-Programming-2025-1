using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_bmi_color_cs
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbmi_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtc.Text);
            double w = double.Parse(txtk.Text);
            double bmi = w / (h / 100 * h / 100);
            lblbmi.Text = "bmi = " + bmi;

            // 비만도 측정
            if (bmi < 20)
            {
                lblp.Text = "판정 : 저체중입니다.";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (bmi < 25)
            {
                lblp.Text = "판정 : 정상체중입니다.";
                pictureBox1.BackColor = Color.Yellow;
            }
            else if (bmi < 30)
            {
                lblp.Text = "판정 : 경도비만입니다.";
                pictureBox1.BackColor = Color.Green;
            }
            else if (bmi < 40)
            {
                lblp.Text = "판정 : 비만입니다.";
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                lblp.Text = "판정 : 고도비만입니다.";
                pictureBox1.BackColor = Color.Black;
            }
        }
    }
}
