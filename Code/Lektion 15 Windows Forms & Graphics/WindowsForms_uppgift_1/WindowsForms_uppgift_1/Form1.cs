using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_uppgift_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            float fValue1 = 0;
            float fValue2 = 0;

            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);

            if (fValue1 > fValue2)
            {
                lbResult.Text = "Value1 is bigger.";
            }

            else if (fValue2 > fValue1)
            {
                lbResult.Text = "Value2 is bigger.";
            }

            else
            {
                lbResult.Text = "Both values ar equaly big.";
            }
        }
    }
}
