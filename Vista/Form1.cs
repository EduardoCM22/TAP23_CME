
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Conexion con = new Conexion();

            /*MessageBox.Show(con.Conectar()+"");*/
            List<Category> categorias= new CategoryDAO().obtenerTodas();
            dgvCaterorias.DataSource = categorias;

            //Desactivar la adición, eliminación y edición el el gridview
            dgvCaterorias.AllowUserToAddRows = false;
            dgvCaterorias.AllowUserToDeleteRows= false;
            dgvCaterorias.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvCaterorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAddEdit frmAddEdit = new FrmAddEdit();
            frmAddEdit.FormClosed += new FormClosedEventHandler(actualizarTabla);
            frmAddEdit.AddOrEdit = true;
            frmAddEdit.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmAddEdit frmAddEdit = new FrmAddEdit();
            frmAddEdit.FormClosed += new FormClosedEventHandler(actualizarTabla);
            frmAddEdit.AddOrEdit = false;
            frmAddEdit.ColumnId = (int)dgvCaterorias.SelectedCells[0].Value;
            frmAddEdit.NombreAct = dgvCaterorias.SelectedCells[1].Value.ToString();
            frmAddEdit.DescripAct = dgvCaterorias.SelectedCells[2].Value.ToString();
            frmAddEdit.actualizarTxts();
            frmAddEdit.ShowDialog();
        }

        private void actualizarTabla(object sender, FormClosedEventArgs e)
        {
            Conexion con = new Conexion();

            /*MessageBox.Show(con.Conectar()+"");*/
            List<Category> categorias = new CategoryDAO().obtenerTodas();
            dgvCaterorias.DataSource = categorias;

            //Desactivar la adición, eliminación y edición el el gridview
            dgvCaterorias.AllowUserToAddRows = false;
            dgvCaterorias.AllowUserToDeleteRows = false;
            dgvCaterorias.EditMode = DataGridViewEditMode.EditProgrammatically;

            //Activar la selección por fila en lugar de columna
            dgvCaterorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
