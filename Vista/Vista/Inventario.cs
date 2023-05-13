using Datos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Vista
{
    public partial class Inventario : Form
    {
        private Product Productos;
        ProductDAO productDAO = new ProductDAO();
        public Inventario()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos() 
        {
            foreach(Product product in App.products) {
                if(!product.Discontinued)
                {
                    cbProductos.Items.Add(product);
                }
            }

            
            cbProductos.DisplayMember = "ProductName";
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {

            int numProductos = 0;

            if (cbProductos.SelectedIndex.Equals(""))
            {
                MessageBox.Show("Selecciona un Producto");
            }
            else if (txtCantidad.Text.Equals(""))
            {
                MessageBox.Show("Coloque una cantida de productos valida");
            }
            else
            {
                if (int.TryParse(txtCantidad.Text, out numProductos))
                {
                    Productos = (Product)cbProductos.SelectedItem;

                    if((Productos.UnitsInStock + int.Parse(txtCantidad.Text)<= Productos.ReorderLevel * 5))
                    {

                        if(numProductos >= 1)
                        {
                            Productos.UnitsInStock += numProductos;
                            productDAO.Update(Productos);
                            this.Hide();
                            App.huboCambio = true;
                        }
                        else
                        {
                            MessageBox.Show("No se admiten numeros negativos");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Ya hay demaciado stock");
                    }

                }
                else
                {
                    MessageBox.Show("Coloque un valor valido");
                }
            }
        }
    }
}
