using Datos;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAddEdit : Form
    {
        public FrmAddEdit()
        {
            InitializeComponent();
        }

        public Boolean AddOrEdit { get; set; }
        public int ColumnId { get; set; }
        public String NombreAct { get; set; }
        public String DescripAct { get; set; }

        public void actualizarTxts() 
        { 
            txtNombre.Text = NombreAct;
            txtDescripcion.Text = DescripAct;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (AddOrEdit == true)
            {
                CategoryDAO catdao = new CategoryDAO();
                if (txtNombre.Text.Length <= 15)
                {
                    int act = catdao.agregar(new Category(0, txtNombre.Text, txtDescripcion.Text));
                    if (act != 0)
                        MessageBox.Show("Categoria numero " + act + " agregada: " + txtNombre.Text, 
                            "Categoria Agregada");
                    else
                        MessageBox.Show("Un error a ocurrido, no se ha podido agregar la categoria", 
                            "Error");
                    this.Dispose();
                }
                else
                {
                    txtNombre.Text = "";
                    MessageBox.Show("El nombre de la categoria tiene que contener maximo 15 caracteres", 
                        "Nombre Invalido");
                }
            }
            else
            {
                CategoryDAO catdao = new CategoryDAO();
                if (txtNombre.Text.Length <= 15)
                {
                    int act = catdao.actualizar(new Category(ColumnId, txtNombre.Text, txtDescripcion.Text));
                    if (act != 0)
                        MessageBox.Show("Categoria " + NombreAct + " actualizada: " + txtNombre.Text, 
                            "Categoria Actualizada");
                    else
                        MessageBox.Show("Un error a ocurrido, no se ha podido actualizar la categoria", 
                            "Error");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("El nombre de la categoria tiene que contener maximo 15 caracteres", 
                        "Nombre Invalido");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
