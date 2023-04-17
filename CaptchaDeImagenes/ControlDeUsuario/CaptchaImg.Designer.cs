namespace ControlDeUsuario
{
    partial class CaptchaImg
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaImg));
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.tlpContenido = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0png.png");
            this.imageList1.Images.SetKeyName(1, "1png.png");
            this.imageList1.Images.SetKeyName(2, "2png.png");
            this.imageList1.Images.SetKeyName(3, "3png.png");
            this.imageList1.Images.SetKeyName(4, "4png.png");
            this.imageList1.Images.SetKeyName(5, "5png.png");
            this.imageList1.Images.SetKeyName(6, "6png.png");
            this.imageList1.Images.SetKeyName(7, "7png.png");
            this.imageList1.Images.SetKeyName(8, "8png.png");
            this.imageList1.Images.SetKeyName(9, "9png.png");
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(181, 41);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(181, 84);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // tlpContenido
            // 
            this.tlpContenido.ColumnCount = 10;
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContenido.Location = new System.Drawing.Point(16, 16);
            this.tlpContenido.Name = "tlpContenido";
            this.tlpContenido.RowCount = 4;
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenido.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContenido.Size = new System.Drawing.Size(149, 115);
            this.tlpContenido.TabIndex = 2;
            // 
            // CaptchaImg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tlpContenido);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "CaptchaImg";
            this.Size = new System.Drawing.Size(282, 155);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TableLayoutPanel tlpContenido;
    }
}
