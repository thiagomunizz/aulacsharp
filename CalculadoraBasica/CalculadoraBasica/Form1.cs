using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txbValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if (txbValor1.Text == "" || txbValor2.Text == "")
                lblResultado.Text = "Preencha todos os campos!";
            else
            {
                double Valor1 = System.Convert.ToDouble(txbValor1.Text);
                double Valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = Valor1 + Valor2 + "";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            if (txbValor1.Text == "" || txbValor2.Text == "")
                lblResultado.Text = "Preencha todos os campos!";
            else
            {
                double Valor1 = System.Convert.ToDouble(txbValor1.Text);
                double Valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = Valor1 - Valor2 + "";
            }


        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (txbValor1.Text == "" || txbValor2.Text == "")
                lblResultado.Text = "Preencha todos os campos";
            else
            {
                double Valor1 = System.Convert.ToDouble(txbValor1.Text);
                double Valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = Valor1 * Valor2 + "";
            }



        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (txbValor1.Text == "" || txbValor2.Text == "")
                lblResultado.Text = "Preencha todos os campos!";
            else
            {
                double Valor1 = System.Convert.ToDouble(txbValor1.Text);
                double Valor2 = System.Convert.ToDouble(txbValor2.Text);
                lblResultado.Text = Valor1 / Valor2 + "";
            }

        }
    }
}
