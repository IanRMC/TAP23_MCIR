using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Captcha
{
    public class CaptchaEvents : EventArgs
    {
        /// <summary>
        /// Es el resultado de la validación del captcha
        /// </summary>
        public Boolean respuesta { get; set; }
    }
}
