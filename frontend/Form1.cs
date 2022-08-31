using backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            calculadora.num1 = Convert.ToDecimal(txtOperador1.Text);
            calculadora.num2 = Convert.ToDecimal(txtOperador2.Text);

            decimal res = calculadora.Calcular("+");
            lblResultado.Text = res.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            calculadora.num1 = Convert.ToDecimal(txtOperador1.Text);
            calculadora.num2 = Convert.ToDecimal(txtOperador2.Text);

            decimal res = calculadora.Calcular("-");
            lblResultado.Text = res.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            calculadora.num1 = Convert.ToDecimal(txtOperador1.Text);
            calculadora.num2 = Convert.ToDecimal(txtOperador2.Text);

            decimal res = calculadora.Calcular("*");
            lblResultado.Text = res.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            calculadora.num1 = Convert.ToDecimal(txtOperador1.Text);
            calculadora.num2 = Convert.ToDecimal(txtOperador2.Text);

            decimal res = calculadora.Calcular("/");
            lblResultado.Text = res.ToString();
        }
    }
}
