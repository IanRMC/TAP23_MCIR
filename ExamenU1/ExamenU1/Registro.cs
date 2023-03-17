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
    public partial class Registro : Form
    {
        Inicio tiendita;

        public Registro(Inicio venta)
        {
            InitializeComponent();
            tiendita = venta;
            llenar();
        }

        public void llenar()
        {
            foreach (string elemento in tiendita.producto)
            {
                lbxProducto.Items.Add(elemento);
            }
            foreach (int elemento in tiendita.cantidad)
            {
                lbxExistencia.Items.Add(elemento);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int x = 0;
            double y = 0;
            if (int.TryParse(txtExistencia.Text, out x) && double.TryParse(txtPrecio.Text, out y))
            {
                tiendita.producto.Add(txtProducto.Text);
                tiendita.cantidad.Add(int.Parse(txtExistencia.Text));
                tiendita.precio.Add(double.Parse(txtPrecio.Text));
                lbxExistencia.Items.Add(txtExistencia.Text);
                lbxProducto.Items.Add(txtProducto.Text);
            }
            else
            {
                MessageBox.Show("Ponga valores validos");
            }
        }

        private void lbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxExistencia.SelectedIndex = lbxProducto.SelectedIndex;
        }

        private void lbxExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProducto.SelectedIndex = lbxExistencia.SelectedIndex;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
