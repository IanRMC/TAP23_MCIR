using ControlesEjercicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba4AverSiEsLaBuena
{
    public partial class SelectorDeMes : UserControl
    {

        public event EventHandler <ChangeSelectorArgs> Change;
        private int valor = 1;
        private enum meses { Enero, Febrero, Marzo, Abril, Mayo, Junio,
            Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };

        public int Valor
        {
            get { return valor; }
            set
            {

                if (value >= 1 && value <= 12)
                {
                    valor = value;
                    lblmes.Text = Enum.GetName(typeof(meses), valor - 1);
                    String mes = Enum.GetName(typeof(meses), valor - 1);


                    ChangeSelectorArgs datos = new ChangeSelectorArgs();
                    datos.Mes = mes;
                    datos.Valor = valor;
                    Change?.Invoke(this, datos);
                }
                else if (value < 1)
                {
                    valor = 1;
                }
                else
                {
                    valor = 12;
                }
                
            }
        }

        public String Mes
        {
            get { return Enum.GetName(typeof(meses), valor - 1); }
            set
            {
                value = Enum.GetName(typeof(meses), valor - 1);
            }
        }


        public SelectorDeMes()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Valor++;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Valor--;
        }
    }
}
