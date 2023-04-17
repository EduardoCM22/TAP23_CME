using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptchaDeImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void captchaImg1_Validar(object sender, ControlDeUsuario.Validacion e)
        {
            MessageBox.Show("Valido: " + e.Valido);
        }

    }
}
