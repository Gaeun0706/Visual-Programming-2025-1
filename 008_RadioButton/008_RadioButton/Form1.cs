using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_RadioButton
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string s = "";

            if (rbK.Checked)
                s += "국적 : 대한민국\n";
            else if(rbC.Checked)
                s += "국적 : 중국\n";
            else if (rbJ.Checked)
                s += "국적 : 일본\n";
            else if (rbOthers.Checked)
                s += "국적 : 그 외 국가\n";

            if (rbMale.Checked)
                s += "성별 : 남성";
            else if (rbFimale.Checked)
                s += "성별 : 여성";

            MessageBox.Show(s, "결과");
        }
    }
}
