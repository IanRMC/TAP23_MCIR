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
    }
}
