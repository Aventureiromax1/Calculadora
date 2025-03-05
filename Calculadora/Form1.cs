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
        private operations selectedOperation { get; set; }

        private enum operations
        {
            add,
            sub,
            multiply,
            division
        }
        public Calculadora()
        {
            InitializeComponent();
        }
        void lockbutton()
        {
            BtnEqual.Enabled = !(Txt_Result.Text == null || selectedOperation == operations.division && Txt_Result is null);
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            selectedOperation = operations.add;
            value = Convert.ToDouble(Txt_Result.Text);
            Txt_Result.Text += "+";
            Txt_PreviousOp.Text += "+";
            Txt_Result.Text = "";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            selectedOperation = operations.sub;
            value = Convert.ToDouble(Txt_Result.Text);
            Txt_Result.Text += "-";
            Txt_PreviousOp.Text += "-";
            Txt_Result.Text = "";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            selectedOperation = operations.multiply;
            value = Convert.ToDouble(Txt_Result.Text);
            Txt_Result.Text += "×";
            Txt_PreviousOp.Text += "×";
            Txt_Result.Text = "";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            selectedOperation = operations.division;
            value = Convert.ToDouble(Txt_Result.Text);
            Txt_Result.Text += "÷";
            Txt_PreviousOp.Text += "÷";
            Txt_Result.Text = "";
            lockbutton();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double result = 0;

            switch (selectedOperation)
            {
                case operations.add:
                    result = value + Convert.ToDouble(Txt_Result.Text);
                    break;
                case operations.sub:
                    result = value - Convert.ToDouble(Txt_Result.Text);
                    break;
                case operations.multiply:
                    result = value * Convert.ToDouble(Txt_Result.Text);
                    break;
                case operations.division:
                    result = value / Convert.ToDouble(Txt_Result.Text);
                    break;
            }
            Txt_Result.Text = result.ToString();
            Txt_PreviousOp.Text = value.ToString();
        }

        private void Btn_n1_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "1";
        }

        private void Btn_n2_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "2";
        }

        private void Btn_n3_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "3";
        }

        private void Btn_n4_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "4";
        }

        private void Btn_n5_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "5";
        }

        private void Btn_n6_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "6";
        }

        private void Btn_n7_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "7";
        }

        private void Btn_n8_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "8";
        }

        private void Btn_n9_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "9";
        }

        private void Btn_n0_Click(object sender, EventArgs e)
        {
            Txt_Result.Text += "0";
        }

        private void BtnRaise_Click(object sender, EventArgs e)
        {
            if (!Txt_Result.Text.Contains(","))
            {
                Txt_Result.Text += ",";
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = "";
            Txt_PreviousOp.Text = "";
            result = 0;
            value = 0;
        }

        private void Txt_Result_TextChanged(object sender, EventArgs e)
        {
            lockbutton();
        }

        private void Txt_PreviousOp_TextChanged(object sender, EventArgs e)
        {
            Txt_PreviousOp.Text += value.ToString();
            //Txt_PreviousOp.Text += operations;
        }
    }
}


