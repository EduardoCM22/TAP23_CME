using Datos;
using Modelos;
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

namespace Vista
{
    public partial class FrmAdquirir : Form
    {

        private List<Product> productos = new ProductDAO().productos();
        ProductDAO p = new ProductDAO();
        int contFilasModificadas;

        public FrmAdquirir()
        {
            InitializeComponent();

            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "ProductName";
            cmbProducto.ValueMember = "ProductId";
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            Product product = (Product)cmbProducto.SelectedItem;
            int unidades;
            if (!int.TryParse(txtAdquirir.Text, out unidades))
            {
                MessageBox.Show("Cantidad Adquirir no valido. Debe ser un número.");
            }
            else
            {
                if (product.UnitsInStock + Convert.ToInt32(txtAdquirir.Text) <= product.Unidades * 5)
                {
                    product.UnitsInStock = product.UnitsInStock + Convert.ToInt32(txtAdquirir.Text);
                    contFilasModificadas = p.adquirir(product);
                    if (contFilasModificadas == 0)
                    {
                        MessageBox.Show("Error al realizar la operación.");
                    }
                    else
                    {
                        MessageBox.Show("Operación realizada exitosamente.");
                    }
                }
                else 
                {
                    MessageBox.Show("UnitsInStock rebasa la cantidad máxima de inventario " +
                        "permitida para ese producto.");
                }
            }
        }
    }
}
