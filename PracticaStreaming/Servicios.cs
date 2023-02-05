using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaStreaming
{
    public partial class Servicios : Form
    {
        public double total;
        ToolTip toolTip = new ToolTip();
        public Servicios()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            total = 0;
            if (rb1Mes.Checked)
            {
                total = getServicio1();
            }
            if (rb2Mes.Checked)
            {
                total = getServicio2();
            }
            if (rb3Mes.Checked)
            {
                total = getServicio3();
            }
            if (rb6Mes.Checked)
            {
                total = getServicio6();
            }
            if (rb12Mes.Checked)
            {
                total = getServicio12();
            }
            if(total != 0)
            {
                if (cbxImpuestos.Checked)
                {
                    total *= 1.16;
                    MessageBox.Show("El total a pagar es " + total + "$");
                }
                else
                {
                    MessageBox.Show("El total a pagar es " + total + "$");
                }
            }
            else
            {
                MessageBox.Show("Escoja una opcion");
            }
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            cboServicio.SelectedIndex = 0;
        }

        private int getServicio1()
        {
            switch (cboServicio.SelectedIndex)
            {
                case 1: return 122; break;
                case 2: return 230; break;
                case 3: return 300; break;
                case 4: return 100; break;
                case 5: return 250; break;
                default: return 0; break;
            }
        }
        private int getServicio2()
        {
            switch (cboServicio.SelectedIndex)
            {
                case 1: return 244; break;
                case 2: return 460; break;
                case 3: return 600; break;
                case 4: return 200; break;
                case 5: return 500; break;
                default: return 0; break;
            }
        }
        private int getServicio3()
        {
            switch (cboServicio.SelectedIndex)
            {
                case 1: return 366; break;
                case 2: return 690; break;
                case 3: return 900; break;
                case 4: return 300; break;
                case 5: return 750; break;
                default: return 0; break;
            }
        }
        private int getServicio6()
        {
            switch (cboServicio.SelectedIndex)
            {
                case 1: return 732; break;
                case 2: return 1380; break;
                case 3: return 1800; break;
                case 4: return 600; break;
                case 5: return 1500; break;
                default: return 0; break;
            }
        }
        private int getServicio12()
        {
            switch(cboServicio.SelectedIndex)
            {
                case 1: return 1464; break;
                case 2: return 2760; break;
                case 3: return 3600; break;
                case 4: return 1200; break;
                case 5: return 3000; break;
                default: return 0; break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cboServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboServicio.SelectedIndex)
            {
                case 1:
                    toolTip.SetToolTip(rb1Mes, "Costo: $122");
                    toolTip.SetToolTip(rb2Mes, "Costo: $244");
                    toolTip.SetToolTip(rb3Mes, "Costo: $366");
                    toolTip.SetToolTip(rb6Mes, "Costo: $732");
                    toolTip.SetToolTip(rb12Mes, "Costo: $1464");
                    break;
                case 2:
                    toolTip.SetToolTip(rb1Mes, "Costo: $230");
                    toolTip.SetToolTip(rb2Mes, "Costo: $460");
                    toolTip.SetToolTip(rb3Mes, "Costo: $690");
                    toolTip.SetToolTip(rb6Mes, "Costo: $1380");
                    toolTip.SetToolTip(rb12Mes, "Costo: $2760");
                    break;
                case 3:
                    toolTip.SetToolTip(rb1Mes, "Costo: $300");
                    toolTip.SetToolTip(rb2Mes, "Costo: $600");
                    toolTip.SetToolTip(rb3Mes, "Costo: $900");
                    toolTip.SetToolTip(rb6Mes, "Costo: $1800");
                    toolTip.SetToolTip(rb12Mes, "Costo: $3600"); 
                    break;
                case 4:
                    toolTip.SetToolTip(rb1Mes, "Costo: $100");
                    toolTip.SetToolTip(rb2Mes, "Costo: $200");
                    toolTip.SetToolTip(rb3Mes, "Costo: $300");
                    toolTip.SetToolTip(rb6Mes, "Costo: $600");
                    toolTip.SetToolTip(rb12Mes, "Costo: $1200"); 
                    break;
                case 5:
                    toolTip.SetToolTip(rb1Mes, "Costo: $250");
                    toolTip.SetToolTip(rb2Mes, "Costo: $500");
                    toolTip.SetToolTip(rb3Mes, "Costo: $750");
                    toolTip.SetToolTip(rb6Mes, "Costo: $1500");
                    toolTip.SetToolTip(rb12Mes, "Costo: $3000"); 
                    break;
                default:
                    toolTip.SetToolTip(rb1Mes, "Selecciona una opcion");
                    toolTip.SetToolTip(rb2Mes, "Selecciona una opcion");
                    toolTip.SetToolTip(rb3Mes, "Selecciona una opcion");
                    toolTip.SetToolTip(rb6Mes, "Selecciona una opcion");
                    toolTip.SetToolTip(rb12Mes, "Selecciona una opcion"); 
                    break;
            }
        }
    }
}
