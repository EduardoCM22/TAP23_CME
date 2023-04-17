using ControlDeUsuario.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeUsuario
{
    public partial class CaptchaImg : UserControl
    {

        public CaptchaImg()
        {
            InitializeComponent();
            crearCaptcha();
        }

        private int dificultad = 10;

        /// <summary>
        /// Genera la cantidad indicada de conjuntos de imágenes que serán requeridos para descifrar el captcha.
        /// </summary>
        [Description("Genera la cantidad indicada de conjuntos " +
            "de imágenes que serán requeridos para descifrar el captcha."), Category("Layout")]
        public int Dificultad
        {
            get { return dificultad; }
            set 
            {
                dificultad = value;
                if (dificultad > 10)
                {
                    dificultad = 10;
                }
                else if (dificultad < 1)
                {
                    dificultad = 1;
                }
                crearCaptcha();
            }
        }

        private int[] arr;

        private void crearCaptcha()
        {
            this.Controls.Remove(tlpContenido);
            this.BackColor = SystemColors.ControlDark;
            this.Width = 56 * dificultad + 80; // +215
            this.Height= 230; // 288

            tlpContenido = new TableLayoutPanel();
            //tlpContenido.BackColor = Color.Red;
            tlpContenido.Width = 56 * dificultad;
            tlpContenido.Height= 230;
            this.Controls.Add(tlpContenido);

            btnGenerar.Location = new Point(tlpContenido.Width + 2, 0);
            btnGenerar.Width = 75;
            btnGenerar.Height = 110;
            btnValidar.Location = new Point(tlpContenido.Width + 2, 120);
            btnValidar.Width = 75;
            btnValidar.Height = 110;

            tlpContenido.ColumnCount = dificultad;
            tlpContenido.RowCount = 4;

            arr = new int[dificultad];
            Random rnd = new Random();
            int aux = 0, n;
            while (aux < dificultad)
            {
                n = rnd.Next(10);
                if (!busqueda(arr, n, aux))
                {
                    arr[aux] = n;
                    aux++;
                }
            }

            for (int i = 0; i < tlpContenido.ColumnCount; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Width = 50; pic.Height = 50;
                pic.Image = imageList1.Images[arr[i]];
                pic.Image.Tag= arr[i];
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                tlpContenido.Controls.Add(pic);
            }
            for (int i = 0; i < tlpContenido.ColumnCount; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "" + i;
                pic.Width = 50; pic.Height = 50;
                pic.Image = Resources.Uppng;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += new EventHandler(upImg);
                tlpContenido.Controls.Add(pic);
            }
            for (int i = 0; i < tlpContenido.ColumnCount; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Width = 50; pic.Height = 50;
                pic.Image = Resources._0png;
                pic.Image.Tag = 0;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                tlpContenido.Controls.Add(pic);
            }
            for (int i = 0; i < tlpContenido.ColumnCount; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "" + i;
                pic.Width = 50; pic.Height = 50;
                pic.Image = Resources.Downpng;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Click += new EventHandler(downImg);
                tlpContenido.Controls.Add(pic);
            }
        }

        private static Boolean busqueda(int[] a, int n, int aux)
        {
            for (int j = 0; j < aux; j++)
            {
                if (n == a[j])
                {
                    return true;
                }
            }
            return false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            crearCaptcha();
        }

        /// <summary>
        /// Ocurre cuando el botón Validar del control ha sido presionado.
        /// </summary>
        [Description("Ocurre cuando el botón Validar del control ha sido presionado."), 
            Category("Action")]
        public event EventHandler<Validacion> Validar;
        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validacion validacion = new Validacion();
            for (int i = 0; i < dificultad; i++) {
                PictureBox picA = (PictureBox)tlpContenido.GetControlFromPosition(i, 0);
                PictureBox picB = (PictureBox)tlpContenido.GetControlFromPosition(i, 2);
                if (!picA.Image.Tag.Equals(picB.Image.Tag))
                {
                    this.BackColor = Color.LightCoral;
                    validacion.Valido = false;
                    Validar?.Invoke(this, validacion);
                    return;
                }
            }
            this.BackColor = Color.LightGreen;
            validacion.Valido = true;
            Validar?.Invoke(this, validacion);
        }
       
        private void upImg(object sender, EventArgs e)
        {
            PictureBox upImg = (PictureBox)sender;
            if (upImg.Name.Equals("0"))
            {
                actUpImg(tlpContenido, 0);
            }
            else if (upImg.Name.Equals("1"))
            {
                actUpImg(tlpContenido, 1);
            }
            else if (upImg.Name.Equals("2"))
            {
                actUpImg(tlpContenido, 2);
            }
            else if (upImg.Name.Equals("3"))
            {
                actUpImg(tlpContenido, 3);
            }
            else if (upImg.Name.Equals("4"))
            {
                actUpImg(tlpContenido, 4);
            }
            else if (upImg.Name.Equals("5"))
            {
                actUpImg(tlpContenido, 5);
            }
            else if (upImg.Name.Equals("6"))
            {
                actUpImg(tlpContenido, 6);
            }
            else if (upImg.Name.Equals("7"))
            {
                actUpImg(tlpContenido, 7);
            }
            else if (upImg.Name.Equals("8"))
            {
                actUpImg(tlpContenido, 8);
            }
            else
            {
                actUpImg(tlpContenido, 9);
            }
        }

        private void actUpImg(TableLayoutPanel tlpContenido, int columna)
        {
            PictureBox pic = (PictureBox)tlpContenido.GetControlFromPosition(columna, 2);
            if ((int)pic.Image.Tag != 9)
            {
                int x = Int32.Parse(pic.Image.Tag.ToString()) + 1;
                pic.Image = imageList1.Images[x];
                pic.Image.Tag = x;
                //Console.WriteLine(pic.Image.Tag);
            }
            else
            {
                pic.Image = imageList1.Images[0];
                pic.Image.Tag = 0;
                //Console.WriteLine(pic.Image.Tag);
            }
        }

        private void downImg(object sender, EventArgs e)
        {
            PictureBox upImg = (PictureBox)sender;
            if (upImg.Name.Equals("0"))
            {
                actDownImg(tlpContenido, 0);
            }
            else if (upImg.Name.Equals("1"))
            {
                actDownImg(tlpContenido, 1);
            }
            else if (upImg.Name.Equals("2"))
            {
                actDownImg(tlpContenido, 2);
            }
            else if (upImg.Name.Equals("3"))
            {
                actDownImg(tlpContenido, 3);
            }
            else if (upImg.Name.Equals("4"))
            {
                actDownImg(tlpContenido, 4);
            }
            else if (upImg.Name.Equals("5"))
            {
                actDownImg(tlpContenido, 5);
            }
            else if (upImg.Name.Equals("6"))
            {
                actDownImg(tlpContenido, 6);
            }
            else if (upImg.Name.Equals("7"))
            {
                actDownImg(tlpContenido, 7);
            }
            else if (upImg.Name.Equals("8"))
            {
                actDownImg(tlpContenido, 8);
            }
            else
            {
                actDownImg(tlpContenido, 9);
            }
        }

        private void actDownImg(TableLayoutPanel tlpContenido, int columna)
        {
            PictureBox pic = (PictureBox)tlpContenido.GetControlFromPosition(columna, 2);
            if ((int)pic.Image.Tag != 0)
            {
                int x = Int32.Parse(pic.Image.Tag.ToString()) - 1;
                pic.Image = imageList1.Images[x];
                pic.Image.Tag = x;
                //Console.WriteLine(pic.Image.Tag);
            }
            else
            {
                pic.Image = imageList1.Images[9];
                pic.Image.Tag = 9;
                //Console.WriteLine(pic.Image.Tag);
            }
        }
    }
}
