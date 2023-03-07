using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Difucion de los datos del controlador con respecto al evento Change

        private void selectorDeMes1_Change(object sender, ControlesEjercicio.ChangeSelectorArgs e)
        {
            MessageBox.Show("Cambio de mes: " + e.Valor + " - " + e.Mes);
        }
    }
}
