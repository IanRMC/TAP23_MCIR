using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hilos_Corredores
{
    public partial class Corredores : Form
    {
        static Random rnd = new Random();
        private Thread t1, t2, t3;
        delegate void StringArgReturningVoidDelegate(Form frm, PictureBox pb);

        public Corredores()
        {
            InitializeComponent();
        }

        private void CorrerProceso(Form frm, PictureBox b)
        {
            int stp = 1;
            if(b.InvokeRequired)
            {
                while (b.Left + b.Width + 20 < frm.Width)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(CorrerProceso);
                    this.Invoke(d, new object[] { frm, b });
                    Thread.Sleep(rnd.Next(1, 80));
                }
            }else
            {
                b.Left += stp;
            }
        }

        private void CorreHilo(out Thread hilo, PictureBox pb)
        {
            ThreadStart delegado = () => CorrerProceso(this, pb);
            hilo = new Thread(delegado);
            hilo.Start();
        }

        public void Multiple()
        {
            while (t1.IsAlive && t2.IsAlive && t3.IsAlive) ;

            int ganador;
            if(!t1.IsAlive)ganador = 1;
            else if(!t2.IsAlive)ganador = 2;
            else ganador = 3;
            while(t1.IsAlive || t2.IsAlive || t3.IsAlive) ;
            MessageBox.Show("El corredor " + ganador + " fue el ganador");
        }

        private void buttonIniciar1_Click(object sender, EventArgs e)
        {
            CorreHilo(out t1, pictureBox1);
        }

        private void buttonIniciar2_Click(object sender, EventArgs e)
        {
            CorreHilo (out t2, pictureBox2);
        }

        private void buttonIniciar3_Click(object sender, EventArgs e)
        {
            CorreHilo (out t3, pictureBox3);
        }

        private void buttonIniciarTodos_Click(object sender, EventArgs e)
        {
            CorreHilo(out t1, pictureBox1);
            CorreHilo(out t2, pictureBox2);
            CorreHilo(out t3, pictureBox3);

            ThreadStart d1 = () => Multiple();
            Thread hilo = new Thread(d1);
            hilo.Start();
        }
    }
}
