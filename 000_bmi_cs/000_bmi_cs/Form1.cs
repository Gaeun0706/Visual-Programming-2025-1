using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _000_bmi_cs
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtC.Text); // Parse - 문자열을 데이터로 변환하는 메서드
            double w = double.Parse(txtK.Text);
            double bmi = w / (h / 100 * h / 100);
            lblBMI.Text = "BMI = " + bmi;
        }
    }
}
