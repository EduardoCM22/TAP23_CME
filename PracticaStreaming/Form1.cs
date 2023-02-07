using System.Reflection;

namespace PracticaStreaming
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cboServicios.SelectedIndex = 0;
        }

        public double total;
        public double total2;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            total = total2 = 0;

            if (cboServicios.SelectedIndex == 0)
            {
                if (rb1Mes.Checked)
                {
                    total = 100;
                }
                else if (rb2Meses.Checked)
                {
                    total = 150;
                }
                else if (rb3Meses.Checked)
                {
                    total = 250;
                }
                else if (rb6Meses.Checked)
                {
                    total = 500;
                }
                else if (rb12Meses.Checked)
                {
                    total = 950;
                }

                if (cbxImpuestos.Checked)
                {
                    total2 = total * .16 + total;
                    MessageBox.Show("El total de tu compra es: " + total2);
                }
                else
                {
                    MessageBox.Show("El total de tu compra es: " + total);
                }
            }
            else if (cboServicios.SelectedIndex == 1)
            {
                if (rb1Mes.Checked)
                {
                    total = 50;
                }
                else if (rb2Meses.Checked)
                {
                    total = 75;
                }
                else if (rb3Meses.Checked)
                {
                    total = 130;
                }
                else if (rb6Meses.Checked)
                {
                    total = 300;
                }
                else if (rb12Meses.Checked)
                {
                    total = 500;
                }

                if (cbxImpuestos.Checked)
                {
                    total2 = total * .16 + total;
                    MessageBox.Show("El total de tu compra es: " + total2);
                }
                else
                {
                    MessageBox.Show("El total de tu compra es: " + total);
                }
            }
            else {
                if (rb1Mes.Checked)
                {
                    total = 200;
                }
                else if (rb2Meses.Checked)
                {
                    total = 270;
                }
                else if (rb3Meses.Checked)
                {
                    total = 350;
                }
                else if (rb6Meses.Checked)
                {
                    total = 700;
                }
                else if (rb12Meses.Checked)
                {
                    total = 1000;
                }

                if (cbxImpuestos.Checked)
                {
                    total2 = total * .16 + total;
                    MessageBox.Show("El total de tu compra es: " + total2);
                }
                else
                {
                    MessageBox.Show("El total de tu compra es: " + total);
                }
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServicios.SelectedIndex == 0)
            {
                toolTip1.Active = true;
                toolTip2.Active = false;
                toolTip3.Active = false;
            }
            else if (cboServicios.SelectedIndex == 1)
            {
                toolTip2.Active = true;
                toolTip1.Active = false;
                toolTip3.Active = false;
            }
            else 
            {
                toolTip3.Active = true;
                toolTip1.Active = false;
                toolTip2.Active = false;
            }
        }
    }
}