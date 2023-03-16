using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class PuntoDeVenta : Form
    {
        public PuntoDeVenta()
        {
            InitializeComponent();
            productos.Add("JUGOS");
            productos.Add("CHEETOS");
            productos.Add("PEPSI");
            precio.Add(15.5);
            precio.Add(12);
            precio.Add(20.5);
            existencia.Add(15);
            existencia.Add(20);
            existencia.Add(25);
        }

        public static List<String> productos = new List<String>();
        public static List<double> precio = new List<double>();
        public static List<int> existencia = new List<int>();

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeProductos reg = new RegistroDeProductos();
            reg.ShowDialog(this);
        }

        private void ventanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaDeProductos vent = new VentaDeProductos();
            vent.ShowDialog(this);
        }
    }
}
