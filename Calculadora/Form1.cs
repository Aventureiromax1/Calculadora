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
        public enum operations //seleciona a operação a ser feita
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
            BtnEqual.Enabled = !(selectedOperations == operations.division && Txt_Result.Text == "0"); //bloqueia o botão de igual se a divisão for por 0
        }
        private double resultOp()
        {
            if (value2 != infovalor && infovalor != null) //se o valor do 2 numero for diferente do armazenado na operação anterior(numero_historico) ele muda o valor 2 para o numero no visor atualmente.
            {
                value2 = Convert.ToDouble(Txt_Result.Text);
            }
            else
            {
                value2 = infovalor.Value; // se não ele mantem o valor do numero_historico
            }
            //double result = 0;
            switch (selectedOperations) // realiza as operações
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
            value1 = result; //armazena o resultado para a proxima operação
            return value1;
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (!(selectedOperations == operations.add)) //essas operaçoes são realizadas em todos os botoes de operação.
            {
                value1 = double.Parse(Txt_Result.Text);  //armazena o valor do visor
                Txt_Result.Text = ""; //limpa o visor
                selectedOperations = operations.add; //seleciona a operação
                operation = "+"; //seleciona o simbolo da operação
                Txt_PreviousOp.Text = value1 + "+"; //mostra a operaçao no visor de historico
                infovalor = null; //define o valor_historico como nulo, para que ele possa ser utilizado para a proxima operação, como um historico
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
            if (!(infovalor == null)) //se o valor historico for diferente de nulo ele define o valor 2 como o valor historico
            {
                value2 = infovalor.Value;
            }
            else //se não ele armazena o valor do visor
            {
                value2 = double.Parse(Txt_Result.Text);
                infovalor = double.Parse(Txt_Result.Text);
            }
                resultOp(); //realiza a operação
                Txt_Result.Text = Convert.ToString(result); //mostra o resultado no visor
                Txt_PreviousOp.Text = Convert.ToString(value1) + operation; //mostra a operação no visor de historico
        }

        private void Btn_n1_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "0") //se o visor estiver com apenas 0 ele substitui pelo numero
            {
                Txt_Result.Text = "1";
            }
            else //se não ele adiciona
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
            if (!Txt_Result.Text.Contains(",")) //verifica se o visor já possui uma virgula, previnindo coisas como 0,0,0
            {
                if (Txt_Result.Text == "0" || Txt_Result.Text == "")
                {
                    Txt_Result.Text = "0,"; //se o visor estiver vazio ou com 0 ele adiciona a virgula, previnindo ,134
                }
                else
                {
                    Txt_Result.Text += ",";
                }
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e) //limpa o visor e o historico
        {
            Txt_Result.Text = "";       //limpa o visor
            Txt_PreviousOp.Text = "";   //
            result = 0;     //
            value1 = 0;     //define o valor de todas as variaveis para 0
            value2 = 0;     //
            infovalor = null; //reseta o valor historico
            selectedOperations = operations.o; // reseta a operação, (pois quando limpava, ela sempre começava com a operação de adição, por ser a primeira na private enum,
        }                                      // assim impedindo que voce possa clicar em clear, e realizar uma operação de adição em seguida) deste modo a calculadora funciona normalmente

        private void Txt_Result_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Result.Text == "") //sempre que o valor do visor for vazio ele define como 0
            {
                Txt_Result.Text = "0";
            }
            lockbutton(); //verifica se o botão de igual deve ser bloqueado, por conta da virgula
        }

        private void Txt_PreviousOp_TextChanged(object sender, EventArgs e)
        {
            Txt_PreviousOp.Text += value.ToString();
        }
        private void InvSigBtn_Click(object sender, EventArgs e)
        {
            if (Txt_Result.Text.Contains("-")) //verifica se o visor já possui um sinal de negativo, invertendo o numero atual entre positivo e negativo.
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


