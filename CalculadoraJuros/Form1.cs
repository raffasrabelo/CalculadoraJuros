using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Juros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double taxaDeJurosMensal = (double.Parse(txtTaxaJuros.Text) / 100) / 12;
            double valorDaParcela = (double.Parse(txtValorPrincipal.Text) * taxaDeJurosMensal) / (1 - Math.Pow(1 + taxaDeJurosMensal, -int.Parse(txtNumParcelas.Text)));
            double valorTotal = valorDaParcela * int.Parse(txtNumParcelas.Text);
            double valorJuros = valorTotal - double.Parse(txtValorPrincipal.Text);


            lblResultado.Text = "Valor da parcela: R$"
                                + valorDaParcela.ToString("F2")
                                + "\nValor total a ser pago: R$"
                                + valorTotal.ToString("F2")
                                + "\nValor do Juros: R$"
                                + valorJuros.ToString("F2");
        }
    }
}
