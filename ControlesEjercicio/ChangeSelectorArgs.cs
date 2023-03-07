using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesEjercicio
{
    public class ChangeSelectorArgs : EventArgs
    {
        public int Valor { get; set; }
        public String Mes { get; set; }
    }
}
