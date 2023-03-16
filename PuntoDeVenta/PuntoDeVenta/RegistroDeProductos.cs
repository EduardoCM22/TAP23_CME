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
    public partial class RegistroDeProductos : Form
    {
        public RegistroDeProductos()
        {
            InitializeComponent();
            for (int i = 0; i < PuntoDeVenta.productos.Count; i++)
            {
                lbxProductos.Items.Add(PuntoDeVenta.productos[i]);
                lbxExistencia.Items.Add(PuntoDeVenta.existencia[i]);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != "")
            {
                if (double.TryParse(txtPrecio.Text, out double prec) && prec != 0)
                {
                    if (int.TryParse(txtExistencia.Text, out int exist) && exist != 0)
                    {
                        if (PuntoDeVenta.productos.Contains(txtProducto.Text.Trim()))
                        {
                            MessageBox.Show("Registre un nuevo producto",
                                "Producto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            PuntoDeVenta.productos.Add(txtProducto.Text.Trim());
                            PuntoDeVenta.precio.Add(double.Parse(txtPrecio.Text));
                            PuntoDeVenta.existencia.Add(int.Parse(txtExistencia.Text));
                            addListProdExist();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese correctamente las existencias",
                        "Ingreso Existencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese correctamente el precio",
                        "Ingreso Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese correctamente el producto",
                        "Ingreso Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addListProdExist() 
        {
            lbxProductos.Items.Add(PuntoDeVenta.productos[PuntoDeVenta.productos.Count-1]);
            lbxExistencia.Items.Add(PuntoDeVenta.existencia[PuntoDeVenta.existencia.Count - 1]);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxExistencia.SelectedIndex = lbxProductos.SelectedIndex;
        }

        private void lbxExistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProductos.SelectedIndex = lbxExistencia.SelectedIndex;
        }
    }
}
