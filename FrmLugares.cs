using System;
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
            foreach (Button btn in panel1.Controls)
            {
                btn.Tag = "Libre";
                btn.Click += new EventHandler(eventoBoton);
                btn.KeyPress += new KeyPressEventHandler(eventoTecla);
            }
        }

        private void eventoBoton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtNombre.Text.Trim().Length >= 2)
            {
                btn.BackgroundImage = GUI.Properties.Resources.pcOcupada;
                btn.Tag = "Ocupada";
            }
            else
            {
                MessageBox.Show("Se debe ingresar el nombre del ocupante (al menos 2 caracteres)",
                    "Reservar equipo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void eventoTecla(object sender, KeyPressEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            { 
                if (btn.Tag.ToString().Equals("Ocupada"))
                {
                    btn.BackgroundImage = GUI.Properties.Resources.pcLibre;
                    btn.Tag = "Libre";
                } 
                else
                {
                    MessageBox.Show("PC Desocupada");
                }
            }
        }
    }
}
