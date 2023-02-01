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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Double num1 = 0, num2 = 0;
            if(Double.TryParse(txtNum1.Text, out num1) && Double.TryParse(txtNum2.Text, out num2))
            {
                lblResultado.Text = (num1 + num2) + "";
            }
            else
            {
                MessageBox.Show("Valores no validos");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Double num1 = 0, num2 = 0;
            if (Double.TryParse(txtNum1.Text, out num1) && Double.TryParse(txtNum2.Text, out num2))
            {
                lblResultado.Text = (num1 - num2) + "";
            }
            else
            {
                MessageBox.Show("Valores no validos");
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Double num1 = 0, num2 = 0;
            if (Double.TryParse(txtNum1.Text, out num1) && Double.TryParse(txtNum2.Text, out num2))
            {
                lblResultado.Text = (num1 * num2) + "";
            }
            else
            {
                MessageBox.Show("Valores no validos");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Double num1 = 0, num2 = 0;
            if (Double.TryParse(txtNum1.Text, out num1) && Double.TryParse(txtNum2.Text, out num2))
            {
                if(num2 != 0)
                {
                    lblResultado.Text = (num1 / num2) + "";
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre 0");
                }
            }
            else
            {
                MessageBox.Show("Valores no validos");
            }
        }
    }
}
