using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLugares : Form
    {
        private Button bAux;
        public FrmLugares()
        {
            InitializeComponent();
            String resumen = "";
            //Por cada control que se encuentre en la colección Controls del form
            //foreach (Control control in this.Controls)
            //{
            //    if(control is Button)
            //        resumen+= control.Name  + " - " + control.GetType().Name 
            //        + "\n";
            //}
            //MessageBox.Show(resumen);

            foreach (Button btn in panel1.Controls)
            {
                btn.Click += new EventHandler(eventoBoton);
                btn.KeyPress += new KeyPressEventHandler(eventoTecla);
                
                
            }
        }

        private void eventoBoton(Object boton, EventArgs e)
        {
            Button btn = (Button)boton;
            if(btn.Tag == null)
            {
                if (txtNombre.Text.Trim().Length >= 2)
                {
                    btn.BackgroundImage =
                    GUI.Properties.Resources.pcOcupada;
                    toolTip1.SetToolTip(btn, txtNombre.Text);
                    btn.Tag = txtNombre.Text.Trim();
                    txtNombre.Text = "";
                }
                else
                {
                    MessageBox.Show("Se debe ingresar el nombre del ocupante (al menos 2 caracteres)",
                        "Reservar equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bAux = btn;
                contextMenuStrip2.Visible = true;
            }
            
        }

        private void desocupar(Object boton)
        {
            Button btn = (Button)boton;
            btn.BackgroundImage = GUI.Properties.Resources.pcLibre;
            toolTip1.SetToolTip(btn, "");
            btn.Tag = null;
        }

        private void eventoTecla(Object boton, KeyPressEventArgs e)
        {
            //KeyPressEventArgs argumentos = (KeyPressEventArgs)e;
            //if (e.KeyChar != (int)Keys.D && e.KeyChar != (int)Keys.D+32) return;

            //if (e.KeyChar != 'D' && e.KeyChar != 'd') return;
            if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                

                Button btn = (Button)boton;
                if (btn.Tag != null)
                {
                    DialogResult respuesta = MessageBox.Show("Este esquipo lo tiene reservado " + btn.Tag + ", ¿Estás seguro que deseas liberarlo?", "Eliminar reserva de equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        desocupar (btn);
                    }
                }
                else
                {
                    MessageBox.Show("Este equipo ya estaba disponible",
                        "Reservar equipo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void crearLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String respuesta;
            int lugares=0;
            do {
                InputDialog frmDialogo = new InputDialog();
                frmDialogo.Titulo = "Configuración del boratorio";
                frmDialogo.Text = "¿Cuántos espacios deseas que tenga el laboratorio?";
                frmDialogo.ShowDialog();
                respuesta = frmDialogo.Valor;
            } while(respuesta!=null && (respuesta.Trim().Equals("") || !int.TryParse(respuesta,out lugares)));

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void desocuparToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Este esquipo lo tiene reservado " + bAux.Tag + ", ¿Estás seguro que deseas liberarlo?", "Eliminar reserva de equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                desocupar(bAux);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnOcupados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (Button btn in panel1.Controls)
            {
                if (btn.Tag != null)
                {
                    txt = btn.Text + ": " + btn.Tag + "\n" + txt;
                }
            }
            MessageBox.Show("Lugares ocupados: \n" + txt);
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (Button btn in panel1.Controls)
            {
                txt = btn.Text + ", " + txt;
            }
            MessageBox.Show("Lugares ocupados: \n" + txt);
        }
    }
}
