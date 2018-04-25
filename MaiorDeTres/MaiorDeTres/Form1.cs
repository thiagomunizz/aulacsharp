using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaiorDeTres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txbValorA.Text == "" || txbValorB.Text == "" || txbValorC.Text == "")
            {
                lblResposta.Text = "Preencha todos os campos!";
            }
            else
            {

                double ValorA = System.Convert.ToDouble(txbValorA.Text);
                double ValorB = System.Convert.ToDouble(txbValorB.Text);
                double ValorC = System.Convert.ToDouble(txbValorC.Text);



                if (ValorA > ValorB && ValorA > ValorC)
                {
                    lblResposta.Text = "O maior valor é A";
                }

                else if (ValorA == ValorC && ValorB == ValorA)
                {
                    lblResposta.Text = "Os valores de A, B e C são iguais!";
                }

                else if (ValorB > ValorA && ValorB > ValorC)
                {
                    lblResposta.Text = "O maior valor é B";
                }

                else if (ValorC > ValorB && ValorC > ValorA)
                {
                    lblResposta.Text = "O maior valor é C";
                }

                else if (ValorA == ValorB)
                {
                    lblResposta.Text = "Os valores de A e B são iguais e maiores que C.";
                }

                else if (ValorC == ValorA)
                {
                    lblResposta.Text = "Os valores de C e A são iguais e maiores que B.";
                }

                else if (ValorB == ValorC)
                {
                    lblResposta.Text = "Os valores de B e C são iguais e maiores que A.";
                }









            }
        }
    }
}
