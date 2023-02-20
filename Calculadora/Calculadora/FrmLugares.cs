using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
            String resumen = "";
            //Por cada control que se encuentre en la colección Controls del form
            //foreach (Control control in this.Controls)
            //{
            //    if(control is Button)
            //        resumen+= control.Name  + " - " + control.GetType().Name 
            //        + "\n";
            //}
            //MessageBox.Show(resumen);

            foreach (Button btn in panel1.Controls)
            {
                btn.Click += new EventHandler(eventoBoton);
                btn.KeyPress += new KeyPressEventHandler(eventoTecla);
            }
        }

        private void eventoBoton(Object boton, EventArgs e)
        {
            Button btn = (Button)boton;
            if (txtNombre.Text.Trim().Length >= 2)
            {
                if (btn.Tag == null)
                {
                    btn.BackgroundImage = GUI.Properties.Resources.pcOcupada;
                    btn.Tag = txtNombre.Text.Trim();
                    toolTip1.SetToolTip(btn, txtNombre.Text);
                    btn.ContextMenuStrip = contextMenuStrip1;
                }
                else
                    MessageBox.Show("No es posible reservar un equipo en uso", "Equipo En Uso", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Se debe ingresar el nombre del ocupante\n(Al menos 2 caracteres)",
                    "Reservar equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Select();
            }
        }

        private void eventoTecla(Object boton, KeyPressEventArgs e)
        {
            //KeyPressEventArgs argumentos = (KeyPressEventArgs)e;
            //if (e.KeyChar != (int)Keys.D && e.KeyChar != (int)Keys.D+32) return;
            //if (e.KeyChar != 'D' && e.KeyChar != 'd') return;

            if (e.KeyChar == 'D' || e.KeyChar == 'd')
            {
                Button btn = (Button)boton;
                if (btn.Tag != null)
                {
                    DialogResult respuesta = MessageBox.Show("Este equipo lo tiene reservado " +
                        btn.Tag + "\n¿Estás seguro que deseas liberarlo?", "Eliminar Reserva De Equipo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        btn.BackgroundImage = GUI.Properties.Resources.pcLibre;
                        btn.Tag = null;
                        toolTip1.SetToolTip(btn, "");
                        btn.ContextMenuStrip = null;
                    }
                }
                else
                    MessageBox.Show("Este equipo ya estaba disponible", "Reservar Equipo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisponibles_Click(object sender, EventArgs e)
        {
            String disponibles = "";
            foreach (Button btn in panel1.Controls) 
            {
                if (btn.Tag == null) 
                {
                    disponibles += btn.Text + ", ";
                }
            }
            if (disponibles.Length > 0)
                disponibles = disponibles.Substring(0, disponibles.Length - 2) + ".";
            else
                disponibles = "";
            MessageBox.Show("Equipos disponibles: " + disponibles, "Equipos Disponibles", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOcupados_Click(object sender, EventArgs e)
        {
            String ocupados = "";
            foreach (Button btn in panel1.Controls)
            {
                if (btn.Tag != null)
                {
                    ocupados += (btn.Text + " - " + toolTip1.GetToolTip(btn) + "\n");
                }
            }
            MessageBox.Show("Equipos ocupados:\n" + ocupados, "Equipos Ocupados", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void crearLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String respuesta;
            //int lugares = 0;
            //do
            //{
            //    InputDialog frmDialogo = new InputDialog();
            //    frmDialogo.Titulo = "Configuaracion del laboratorio";
            //    frmDialogo.Texto = "Cuantos espacios deseas que tenga el laboratorio?";
            //    frmDialogo.ShowDialog();
            //    respuesta = frmDialogo.Valor;
            //} while (respuesta != null  && (respuesta.Trim().Equals("") || 
            //!int.TryParse(respuesta, out lugares)));
        }

        private void desocuparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuStrip1.SourceControl.Tag != null)
            {
                DialogResult respuesta = MessageBox.Show("Este equipo lo tiene reservado " +
                    contextMenuStrip1.SourceControl.Tag + "\n¿Estás seguro que deseas liberarlo?",
                    "Eliminar Reserva De Equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    contextMenuStrip1.SourceControl.BackgroundImage = GUI.Properties.Resources.pcLibre;
                    contextMenuStrip1.SourceControl.Tag = null;
                    toolTip1.SetToolTip(contextMenuStrip1.SourceControl, "");
                    contextMenuStrip1.SourceControl.ContextMenuStrip = null;
                }
            }
            //MessageBox.Show(sender.ToString());
            //MessageBox.Show(contextMenuStrip1.SourceControl.ToString());
        }
    }
}
