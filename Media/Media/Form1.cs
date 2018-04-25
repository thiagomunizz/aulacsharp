using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (txb1Bim.Text == "" || txb2Bim.Text == "" || txb3Bim.Text == "" || txb4Bim.Text == "")
                lblMedia.Text = "Preencha todos os campos!";
            else
            {
                double PrimeiroBim = System.Convert.ToDouble(txb1Bim.Text);
                double SegundoBim = System.Convert.ToDouble(txb2Bim.Text);
                double TerceiroBim = System.Convert.ToDouble(txb3Bim.Text);
                double QuartoBim = System.Convert.ToDouble(txb4Bim.Text);

                lblMedia.Text = "O aluno " + txbNome.Text + " teve a média de: " + (PrimeiroBim + SegundoBim + TerceiroBim + QuartoBim) / 4 + ".";
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb2bim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
