using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HilosCorredores
{
    public partial class Corredores : Form
    {
        static Random rng = new Random();
        private Thread t1, t2, t3;
        delegate void StringArgReturningVoidDelegate(Form frm, PictureBox pb);

        private void CorrerProceso(Form frm, PictureBox b)
        {
            int stp = 3;
            if (b.InvokeRequired)
            {
                while (b.Left + b.Width + 20 < frm.Width)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(CorrerProceso);
                    this.Invoke(d, new object[] { frm, b });
                    Thread.Sleep(rng.Next(1, 100));
                }
            }
            else
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

        private void buttonIniciar1_Click(object sender, EventArgs e)
        {
            CorreHilo(out t1, pictureBox1);
        }

        private void buttonIniciar2_Click(object sender, EventArgs e)
        {
            CorreHilo(out t2, pictureBox2);
        }

        private void buttonIniciar3_Click(object sender, EventArgs e)
        {
            CorreHilo(out t3, pictureBox3);
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

        public void Multiple()
        {
            while (t1.IsAlive && t2.IsAlive && t3.IsAlive) ;
            int ganador;
            if (!t1.IsAlive)
                ganador = 1;
            else if(!t2.IsAlive)
                ganador = 2;
            else
                ganador = 3;
            while (t1.IsAlive || t2.IsAlive || t3.IsAlive) ;
            MessageBox.Show("El corredor " + ganador + " fue el gandor");
        }
        /*
         * La palabra clave out hace que los argumentos se pasen por referencia. 
         * Hace que el parámetro formal sea un alias para el argumento, que debe ser una variable. 
         * En otras palabras, cualquier operación en el parámetro se realiza en el argumento. 
         * Esto es como la palabra clave ref, salvo que ref requiere que se inicialice la variable antes de pasarla.
         * 
         * Pasar por referencia significa pasar el acceso a la variable al método.
         * Una variable de un tipo de referencia contiene una referencia a sus datos.
         * 
         *OUT: especifica que se trata de un parámetro de salida. Son parámetros cuyo valor 
         *es devuelto después de la ejecución el procedimiento al bloque PL/SQL que lo llamó. 
         *Las funciones PLSQL no admiten parámetros de salida.
         */

        public Corredores()
        {
            InitializeComponent();
        }
    }
}
