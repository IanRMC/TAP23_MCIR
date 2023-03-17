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
    public partial class Venta : Form
    {
        Inicio tiendita;
        public Venta(Inicio productos)
        {
            InitializeComponent();
            tiendita = productos;
            llenarCBX();
        }

        public void llenarCBX()
        {
            foreach (string elemento in tiendita.producto)
            {
                cbxProducto.Items.Add(elemento);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (int.TryParse(txtUnidades.Text, out x) && cbxProducto.SelectedIndex >= 0)
            {
                if (int.Parse(txtUnidades.Text) <= tiendita.cantidad[cbxProducto.SelectedIndex])
                {
                    int busqueda = lbxProducto.FindString(cbxProducto.Text);


                    if (busqueda != -1)
                    {
                        lbxProducto.SelectedIndex = busqueda;
                        String c = lbxUnidades.SelectedItem.ToString();
                        lbxUnidades.Items.RemoveAt(busqueda);
                        lbxUnidades.Items.Insert(busqueda, int.Parse(c)+int.Parse(txtUnidades.Text));
                        lblTotal.Text = "" + (tiendita.precio[cbxProducto.SelectedIndex] * int.Parse(txtUnidades.Text) + double.Parse(lblTotal.Text));

                    }
                    else
                    {
                        tiendita.cantidad[cbxProducto.SelectedIndex] -= int.Parse(txtUnidades.Text);
                        lbxProducto.Items.Add(tiendita.producto[cbxProducto.SelectedIndex]);
                        lbxPrecio.Items.Add(tiendita.precio[cbxProducto.SelectedIndex]);
                        lbxUnidades.Items.Add(txtUnidades.Text);
                        lblTotal.Text = "" + (tiendita.precio[cbxProducto.SelectedIndex] * int.Parse(txtUnidades.Text) + double.Parse(lblTotal.Text));
                    }


                }
                else
                {
                    MessageBox.Show("No hay suficiente Stock (Solo hay: " + tiendita.cantidad[cbxProducto.SelectedIndex] + ")");
                }
            }
            else
            {
                MessageBox.Show("Inserte un valor valido");
            }
        }

        private void lbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxPrecio.SelectedIndex = lbxProducto.SelectedIndex;
            lbxUnidades.SelectedIndex = lbxProducto.SelectedIndex;
        }

        private void lbxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProducto.SelectedIndex = lbxPrecio.SelectedIndex;
            lbxUnidades.SelectedIndex = lbxPrecio.SelectedIndex;
        }

        private void lbxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProducto.SelectedIndex = lbxUnidades.SelectedIndex;
            lbxPrecio.SelectedIndex = lbxUnidades.SelectedIndex;
        }
    }
}
