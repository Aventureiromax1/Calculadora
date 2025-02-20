using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        void AttributeOperator(string OpSign)
        {
            Txt_RunningOp.Text = OpSign;
            BtnEqual.Enabled = true;
        }
        void lockbutton()
        {
            BtnEqual.Enabled = !(Txt_RunningOp.Text == null || Txt_RunningOp.Text == BtnDivision.Text && (double)NumOper2.Value == 0);
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            AttributeOperator(BtnSoma.Text);
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            AttributeOperator(BtnMinus.Text);
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            AttributeOperator(BtnMultiply.Text);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            AttributeOperator(BtnDivision.Text);
            lockbutton();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double num1, num2, result = 0;
            num1 = (double)numOper1.Value;
            num2 = (double)NumOper2.Value;

            if (Txt_RunningOp.Text == BtnSoma.Text)
            {
                result = num1 + num2;

            }
            else if (Txt_RunningOp.Text == BtnMinus.Text)
            {
                result = num1 - num2;
            }
            else if (Txt_RunningOp.Text == BtnMultiply.Text)
            {
                result = num1 * num2;
            }
            else if (Txt_RunningOp.Text == BtnDivision.Text)
            {
                result = num1 / num2;
            }
            Txt_Result.Text = result.ToString();
        }

        private void NumOper2_ValueChanged(object sender, EventArgs e)
        {
            lockbutton();
        }
    }
}

