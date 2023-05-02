using Modelos;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Categoria : Form
    {

        private Category Categorias;
        private CategoryDAO AgreEdi = new CategoryDAO();
        public bool AgOEd;
        private Form1 formulario;
        public Category seleccion;

        public Categoria(Form1 formulario)
        {
            InitializeComponent();
            this.formulario = formulario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if(AgOEd)
            {
                if (txtDescripcion.Text.Equals("") || txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Complete los Campos Vacios");
                    return;
                }

                Categorias = new Category(0, txtNombre.Text, txtDescripcion.Text);
                AgreEdi.agregar(Categorias);
                formulario.llenado();
                txtDescripcion.Text = "";
                txtNombre.Text = "";
                this.Hide();
            }
            else
            {
                
                if (txtDescripcion.Text.Equals("") || txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Complete los Campos Vacios");
                    return;
                }

                Categorias = new Category(seleccion.CategoryId, txtNombre.Text, txtDescripcion.Text);
                AgreEdi.Editar(Categorias);
                formulario.llenado();
                txtDescripcion.Text = "";
                txtNombre.Text = "";
                this.Hide();

            }

        }

        public void llen()
        {
            txtDescripcion.Text = seleccion.Description;
            txtNombre.Text = seleccion.CategoryName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            this.Hide();
        }
    }
}
