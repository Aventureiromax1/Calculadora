using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public double result { get; set; }

        public double value { get; set; }
        private double value1;
        private double value2;
        private double? infovalor = null;
        private operations selectedOperations;
        private string operation = "";
        public enum operations
        {
            o,
            add,
            sub,
            multiply,
            division
        }
        public Calculadora()
        {
            InitializeComponent();
            Txt_Result.Text = "0";
        }
        void lockbutton()
        {
            BtnEqual.Enabled = !(selectedOperations == operations.division && Txt_Result.Text == "0");
        }
        private double resultOp()
        {
            if (value2 != infovalor && infovalor != null)
            {
                value2 = Convert.ToDouble(Txt_Result.Text);
            }
            else
            {
                value2 = infovalor.Value;
            }
            //double result = 0;
            switch (selectedOperations)
            {
                case operations.add:
                    result = value1 + value2;
                    break;
                case operations.sub:
                    result = value1 - value2;
                    break;
                case operations.multiply:
                    result = value1 * value2;
                    break;
                case operations.division:
                    result = value1 / value2;
                    break;
            }
            value1 = result;
            return value1;
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (!(selectedOperations == operations.add))
            {
                value1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                selectedOperations = operations.add;
                operation = "+";
                Txt_PreviousOp.Text = value1 + "+";
                infovalor = null;
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (!(selectedOperations == operations.sub))
            {
                value1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                selectedOperations = operations.sub;
                operation = "-";
                Txt_PreviousOp.Text = value1 + "-";
                infovalor = null;
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (!(selectedOperations == operations.multiply))
            {
                value1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                selectedOperations = operations.multiply;
                operation = "x";
                Txt_PreviousOp.Text = value1 + "x";
                infovalor = null;
            }

        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            if (!(selectedOperations == operations.division))
            {
                value1 = double.Parse(Txt_Result.Text);
                Txt_Result.Text = "";
                selectedOperations = operations.division;
                operation = "÷";
                Txt_PreviousOp.Text = value1 + "÷";
                infovalor = null;
                lockbutton();
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (!(infovalor == null))
            {
                value2 = infovalor.Value;
            }
            else
            {
                infovalor = double.Parse(Txt_Result.Text);
            }
                resultOp();
                Txt_Result.Text = Convert.ToString(result);
                Txt_PreviousOp.Text = Convert.ToString(value1) + operation;
        }

        private void Btn_n1_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "1";
            }
            else
            {
                Txt_Result.Text += "1";
            }
        }

        private void Btn_n2_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "2";
            }
            else
            {
                Txt_Result.Text += "2";
            }
        }

        private void Btn_n3_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "3";
            }
            else
            {
                Txt_Result.Text += "3";
            }
        }

        private void Btn_n4_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "4";
            }
            else
            {
                Txt_Result.Text += "4";
            }
        }

        private void Btn_n5_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "5";
            }
            else
            {
                Txt_Result.Text += "5";
            }
        }

        private void Btn_n6_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "6";
            }
            else
            {
                Txt_Result.Text += "6";
            }
        }

        private void Btn_n7_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "7";
            }
            else
            {
                Txt_Result.Text += "7";
            }
        }

        private void Btn_n8_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "8";
            }
            else
            {
                Txt_Result.Text += "8";
            }
        }

        private void Btn_n9_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "9";
            }
            else
            {
                Txt_Result.Text += "9";
            }
        }

        private void Btn_n0_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0")
            {
                Txt_Result.Text = "0";
            }
            else
            {
                Txt_Result.Text += "0";
            }
        }

        private void BtnRaise_Click(object sender, EventArgs e)
        {
            if (!Txt_Result.Text.Contains(","))
            {
                if (Txt_Result.Text == "0" || Txt_Result.Text == "")
                {
                    Txt_Result.Text = "0,";
                }
                else
                {
                    Txt_Result.Text += ",";
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = "";
            Txt_PreviousOp.Text = "";
            result = 0;
            value1 = 0;
            value2 = 0;
            infovalor = null;
            selectedOperations = operations.o;
        }

        private void Txt_Result_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "")
            {
                Txt_Result.Text = "0";
            }
            lockbutton();
        }

        private void Txt_PreviousOp_TextChanged(object sender, EventArgs e)
        {
            Txt_PreviousOp.Text += value.ToString();
        }
        private void InvSigBtn_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text.Contains("-"))
            {
                Txt_Result.Text = Txt_Result.Text.Trim('-');
            }
            else
            {
                Txt_Result.Text = "-" + Txt_Result.Text;
            }
        }
    }
}


