
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace Vista
{
    public partial class Form1 : Form
    {

        Categoria AgreYEdi;
        CategoryDAO category = new CategoryDAO();

        public Form1()
        {
            InitializeComponent();
            AgreYEdi = new Categoria(this);
            llenado();
        }

        public void llenado()
        {
            Conexion con = new Conexion();

            /*MessageBox.Show(con.Conectar()+"");*/
            List<Category> categorias = new CategoryDAO().obtenerTodas();
            dgvCaterorias.DataSource = categorias;

            //Desactivar la adición, eliminación y edición el el gridview
            dgvCaterorias.AllowUserToAddRows = false;
            dgvCaterorias.AllowUserToDeleteRows = false;
            dgvCaterorias.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvCaterorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            AgreYEdi.AgOEd = true;
            AgreYEdi.Show();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AgreYEdi.AgOEd = false;
            DataGridViewRow filaSeleccionada = dgvCaterorias.SelectedRows[0];
            String id = filaSeleccionada.Cells[0].Value.ToString();

            Category seleccion = category.obtenerTodas()[int.Parse(id)-1];

            AgreYEdi.seleccion = seleccion;
            AgreYEdi.llen();
            
            AgreYEdi.Show();
        }
    }
}
