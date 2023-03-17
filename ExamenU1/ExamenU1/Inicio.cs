using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU1
{
    public partial class Inicio : Form
    {
        public List<String> producto = new List<String>();
        public List<double> precio = new List<double>();
        public List<int> cantidad = new List<int>();
        public Inicio()
        {
            InitializeComponent();
        }

        private void tstrRegistro_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(this);
            registro.Show();
        }

        private void tstrVentas_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta(this);
            venta.Show();
        }
    }
}
