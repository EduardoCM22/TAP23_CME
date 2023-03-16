namespace PuntoDeVenta
{
    partial class VentaDeProductos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxProducto = new System.Windows.Forms.ListBox();
            this.lbxPrecio = new System.Windows.Forms.ListBox();
            this.lbxUnidades = new System.Windows.Forms.ListBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidades";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(89, 132);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(100, 22);
            this.txtUnidad.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(141, 211);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 37);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(158, 294);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 32);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Unidades";
            // 
            // lbxProducto
            // 
            this.lbxProducto.FormattingEnabled = true;
            this.lbxProducto.ItemHeight = 16;
            this.lbxProducto.Location = new System.Drawing.Point(319, 57);
            this.lbxProducto.Name = "lbxProducto";
            this.lbxProducto.Size = new System.Drawing.Size(149, 276);
            this.lbxProducto.TabIndex = 10;
            this.lbxProducto.SelectedIndexChanged += new System.EventHandler(this.lbxProducto_SelectedIndexChanged);
            // 
            // lbxPrecio
            // 
            this.lbxPrecio.FormattingEnabled = true;
            this.lbxPrecio.ItemHeight = 16;
            this.lbxPrecio.Location = new System.Drawing.Point(474, 57);
            this.lbxPrecio.Name = "lbxPrecio";
            this.lbxPrecio.Size = new System.Drawing.Size(149, 276);
            this.lbxPrecio.TabIndex = 11;
            this.lbxPrecio.SelectedIndexChanged += new System.EventHandler(this.lbxPrecio_SelectedIndexChanged);
            // 
            // lbxUnidades
            // 
            this.lbxUnidades.FormattingEnabled = true;
            this.lbxUnidades.ItemHeight = 16;
            this.lbxUnidades.Location = new System.Drawing.Point(630, 57);
            this.lbxUnidades.Name = "lbxUnidades";
            this.lbxUnidades.Size = new System.Drawing.Size(149, 276);
            this.lbxUnidades.TabIndex = 12;
            this.lbxUnidades.SelectedIndexChanged += new System.EventHandler(this.lbxUnidades_SelectedIndexChanged);
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(89, 57);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(153, 24);
            this.cbxProducto.TabIndex = 13;
            // 
            // VentaDeProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.lbxUnidades);
            this.Controls.Add(this.lbxPrecio);
            this.Controls.Add(this.lbxProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentaDeProductos";
            this.Text = "Venta De Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxProducto;
        private System.Windows.Forms.ListBox lbxPrecio;
        private System.Windows.Forms.ListBox lbxUnidades;
        private System.Windows.Forms.ComboBox cbxProducto;
    }
}