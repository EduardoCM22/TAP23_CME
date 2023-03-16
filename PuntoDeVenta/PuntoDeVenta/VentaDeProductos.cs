using System;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class VentaDeProductos : Form
    {
        public VentaDeProductos()
        {
            InitializeComponent();
            for (int i = 0; i < PuntoDeVenta.productos.Count; i++)
            {
                cbxProducto.Items.Add(PuntoDeVenta.productos[i]);
            }
        }

        private Boolean flag = false;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtUnidad.Text, out int n))
            {
                if (PuntoDeVenta.existencia[cbxProducto.SelectedIndex] == 0)
                {
                    MessageBox.Show("No hay existencias disponibles",
                        "Existencais Agotadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (n == 0)
                {
                    MessageBox.Show("Ingrese correctamente las unidades",
                    "Ingreso Unidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (n <= PuntoDeVenta.existencia[cbxProducto.SelectedIndex])
                {
                    for (int i = 0; i < lbxProducto.Items.Count; i++)
                    {
                        if (cbxProducto.SelectedItem.ToString().Equals(lbxProducto.Items[i].ToString()))
                        {
                            int exist = (int)lbxUnidades.Items[i];
                            lbxUnidades.Items.RemoveAt(i);
                            lbxUnidades.Items.Insert(i, exist + n);
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        flag = false;
                    }
                    else
                    {
                        lbxProducto.Items.Add(PuntoDeVenta.productos[cbxProducto.SelectedIndex]);
                        lbxPrecio.Items.Add(PuntoDeVenta.precio[cbxProducto.SelectedIndex]);
                        lbxUnidades.Items.Add(n);
                    }
                    int existencias = PuntoDeVenta.existencia[cbxProducto.SelectedIndex] - n;
                    double precio = PuntoDeVenta.precio[cbxProducto.SelectedIndex];

                    PuntoDeVenta.existencia.RemoveAt(cbxProducto.SelectedIndex);
                    PuntoDeVenta.existencia.Insert(cbxProducto.SelectedIndex, existencias);

                    lbTotal.Text = double.Parse(lbTotal.Text) + (n * precio) + "";
                }
                else
                {
                    MessageBox.Show("No hay suficientes existencias para la venta [" +
                        PuntoDeVenta.existencia[cbxProducto.SelectedIndex] + "]", "Insuficientes Existencias",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingrese correctamente las unidades",
                    "Ingreso Unidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxPrecio.SelectedIndex = lbxProducto.SelectedIndex;
            lbxUnidades.SelectedIndex = lbxProducto.SelectedIndex;
        }

        private void lbxPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProducto.SelectedIndex = lbxPrecio.SelectedIndex;
            lbxUnidades.SelectedIndex = lbxPrecio.SelectedIndex;
        }

        private void lbxUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProducto.SelectedIndex = lbxUnidades.SelectedIndex;
            lbxPrecio.SelectedIndex = lbxUnidades.SelectedIndex;

        }
    }
}
