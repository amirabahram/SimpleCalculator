using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

       
        bool ValidateInputs()
        {
            bool isValid = true;
            if(txt1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("Please Enter 1st Number!");
            }
            else
            {
                if(txt2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("Please Enter 2nd Number!");
                }
            }

            return isValid;
        }

        private void btnMlt_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int mult = calculate.Multiple((int)txt1.Value, (int)txt2.Value);
                MessageBox.Show("Multiple is: " + mult);
            }
        }

        private void btnDvd_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int dvid = calculate.Divide((int)txt1.Value, (int)txt2.Value);
                MessageBox.Show("Dvide is: " + dvid);
            }
        }

        private void btnMns_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int mns = calculate.Minus((int)txt1.Value, (int)txt2.Value);
                MessageBox.Show("Minus is: " + mns);
            }
        }
        private void btnPls_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int plus = calculate.Plus((int)txt1.Value, (int)txt2.Value);
                MessageBox.Show("Plus is: " + plus);
            }
        }
    }
}
