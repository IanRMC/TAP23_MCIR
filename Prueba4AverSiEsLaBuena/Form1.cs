using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba4AverSiEsLaBuena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectorDeMes1_Change(object sender, ControlesEjercicio.ChangeSelectorArgs e)
        {
            MessageBox.Show("Cambio de mes " + e.Valor + " - Mes: " + e.Mes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectorDeMes1_Load(object sender, EventArgs e)
        {

        }
    }
}
