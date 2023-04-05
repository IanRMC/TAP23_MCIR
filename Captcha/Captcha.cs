using Captcha.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Captcha : UserControl
    {
        /// <summary>
        /// Regresa el resultado del capcha 
        /// </summary>
        [Description("Regresa el resultado del capcha "), Category(), ReadOnly(true)]
        public event EventHandler<CaptchaEvents> Validado;

        private Image[] Images = {Resources.earth, Resources.mars, Resources.mars_landing, Resources.moon, Resources.rocket_boosters, Resources.rocket_flying, Resources.rocket_heavy, Resources.rover, Resources.satellite, Resources.space_station};
        private bool[] imgUsada = new bool[10];
        private Button[] arribas;
        private Button[] abajos;
        private PictureBox[] cap;
        private PictureBox[] capimg;
        private int[] solucion = {1, 2, 3, 4, 5, 6 ,7, 8 ,9, 10};
        private int[] respuesta = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

        public Captcha()
        {
            InitializeComponent();
            Button[] arribas = { btnArriba10, btnArriba9, btnArriba8, btnArriba7, btnArriba6, btnArriba5, btnArriba4, btnArriba3, btnArriba2, btnArriba1 };
            Button[] abajos = { btnAbajo10, btnAbajo9, btnAbajo8, btnAbajo7, btnAbajo6, btnAbajo5, btnAbajo4, btnAbajo3, btnAbajo2, btnAbajo1 };
            PictureBox[] cap = { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox1 };
            PictureBox[] capimg = { pictureBox19, pictureBox18, pictureBox17, pictureBox16, pictureBox15, pictureBox14, pictureBox13, pictureBox12, pictureBox11, pictureBox20 };
            this.arribas = arribas;
            this.abajos = abajos;
            this.cap = cap;
            this.capimg = capimg;
            
        }

        private int dificultad = 10;

        /// <summary>
        /// Deterrmina la cantidad de imagenes que aparecen 
        /// </summary>
        [Description("Deterrmina la cantidad de imagenes que aparecen "), Category(), ReadOnly(true)]
        public int Dificultad
        {
            get { return dificultad; }
            set
            {
                dificultad = value;
                if (dificultad < 0)
                    dificultad = 0;
                else if (dificultad > 10)
                    dificultad = 10;
                Dif();
            }
        }

        private void Dif()
        {
            
            for(int i = 0; i < 10; i++)
            {
                arribas[i].Visible = false;
                abajos[i].Visible = false;
                cap[i].Visible = false;
                capimg[i].Visible = false;
            }

            this.Width = (127 + (76*dificultad));

            for(int i = 0;i < dificultad; i++)
            {
                arribas[i].Visible = true;
                abajos[i].Visible = true;
                cap[i].Visible = true;
                capimg[i].Visible = true;
            }

            Generar();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void Generar()
        {
            for (int i = 0; i < 10; i++)
            {
                imgUsada[i] = true;
            }
            int x;
            for (int i = 0; i < dificultad;)
            {
                Random r = new Random();
                x = r.Next(1, 11);
                if (imgUsada[x - 1])
                {

                    cap[i].Image = Images[x - 1];
                    solucion[i] = x;
                    imgUsada[x - 1] = false;
                    i++;
                }
            }
        }

        private void btnArriba10_Click(object sender, EventArgs e)
        {
            respuesta[0]++;
            if (respuesta[0] > 10)
            {
                respuesta[0] = 1;
            }
            capimg[0].Image = Images[respuesta[0]-1];
        }

        private void btnAbajo10_Click(object sender, EventArgs e)
        {
            respuesta[0]--;
            if (respuesta[0] < 1)
            {
                respuesta[0] = 10;
            }
            capimg[0].Image = Images[respuesta[0] - 1];
        }

        private void btnArriba9_Click(object sender, EventArgs e)
        {
            respuesta[1]++;
            if (respuesta[1] > 10)
            {
                respuesta[1] = 1;
            }
            capimg[1].Image = Images[respuesta[1] - 1];
        }

        private void btnArriba8_Click(object sender, EventArgs e)
        {
            respuesta[2]++;
            if (respuesta[2] > 10)
            {
                respuesta[2] = 1;
            }
            capimg[2].Image = Images[respuesta[2] - 1];
        }

        private void btnArriba7_Click(object sender, EventArgs e)
        {
            respuesta[3]++;
            if (respuesta[3] > 10)
            {
                respuesta[3] = 1;
            }
            capimg[3].Image = Images[respuesta[3] - 1];
        }

        private void btnArriba6_Click(object sender, EventArgs e)
        {
            respuesta[4]++;
            if (respuesta[4] > 10)
            {
                respuesta[4] = 1;
            }
            capimg[4].Image = Images[respuesta[4] - 1];
        }

        private void btnArriba5_Click(object sender, EventArgs e)
        {
            respuesta[5]++;
            if (respuesta[5] > 10)
            {
                respuesta[5] = 1;
            }
            capimg[5].Image = Images[respuesta[5] - 1];
        }

        private void btnArriba4_Click(object sender, EventArgs e)
        {
            respuesta[6]++;
            if (respuesta[6] > 10)
            {
                respuesta[6] = 1;
            }
            capimg[6].Image = Images[respuesta[6] - 1];
        }

        private void btnArriba3_Click(object sender, EventArgs e)
        {
            respuesta[7]++;
            if (respuesta[7] > 10)
            {
                respuesta[7] = 1;
            }
            capimg[7].Image = Images[respuesta[7] - 1];
        }

        private void btnArriba2_Click(object sender, EventArgs e)
        {
            respuesta[8]++;
            if (respuesta[8] > 10)
            {
                respuesta[8] = 1;
            }
            capimg[8].Image = Images[respuesta[8] - 1];
        }

        private void btnArriba1_Click(object sender, EventArgs e)
        {
            respuesta[9]++;
            if (respuesta[9] > 10)
            {
                respuesta[9] = 1;
            }
            capimg[9].Image = Images[respuesta[9] - 1];
        }

        private void btnAbajo9_Click(object sender, EventArgs e)
        {
            respuesta[1]--;
            if (respuesta[1] < 1)
            {
                respuesta[1] = 10;
            }
            capimg[1].Image = Images[respuesta[1] - 1];
        }

        private void btnAbajo8_Click(object sender, EventArgs e)
        {
            respuesta[2]--;
            if (respuesta[2] < 1)
            {
                respuesta[2] = 10;
            }
            capimg[2].Image = Images[respuesta[2] - 1];
        }

        private void btnAbajo7_Click(object sender, EventArgs e)
        {
            respuesta[3]--;
            if (respuesta[3] < 1)
            {
                respuesta[3] = 10;
            }
            capimg[3].Image = Images[respuesta[3] - 1];
        }

        private void btnAbajo6_Click(object sender, EventArgs e)
        {
            respuesta[4]--;
            if (respuesta[4] < 1)
            {
                respuesta[4] = 10;
            }
            capimg[4].Image = Images[respuesta[4] - 1];
        }

        private void btnAbajo5_Click(object sender, EventArgs e)
        {
            respuesta[5]--;
            if (respuesta[5] < 1)
            {
                respuesta[5] = 10;
            }
            capimg[5].Image = Images[respuesta[5] - 1];
        }

        private void btnAbajo4_Click(object sender, EventArgs e)
        {
            respuesta[6]--;
            if (respuesta[6] < 1)
            {
                respuesta[6] = 10;
            }
            capimg[6].Image = Images[respuesta[6] - 1];
        }

        private void btnAbajo3_Click(object sender, EventArgs e)
        {
            respuesta[7]--;
            if (respuesta[7] < 1)
            {
                respuesta[7] = 10;
            }
            capimg[7].Image = Images[respuesta[7] - 1];
        }

        private void btnAbajo2_Click(object sender, EventArgs e)
        {
            respuesta[8]--;
            if (respuesta[8] < 1)
            {
                respuesta[8] = 10;
            }
            capimg[8].Image = Images[respuesta[8] - 1];
        }

        private void btnAbajo1_Click(object sender, EventArgs e)
        {
            respuesta[9]--;
            if (respuesta[9] < 1)
            {
                respuesta[9] = 10;
            }
            capimg[9].Image = Images[respuesta[9] - 1];
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            CaptchaEvents c = new CaptchaEvents();
            for(int i = 0; i < dificultad; i++)
            {
                if(respuesta[i] != solucion[i])
                {
                    this.BackColor = Color.Crimson;
                    c.respuesta = false;
                    Validado?.Invoke(this, c);
                    return;
                }
            }
            this.BackColor = Color.Aquamarine;
            c.respuesta = true;
            Validado?.Invoke(this, c);
        }
    }
}
