namespace PracticaStreaming
{
    partial class Servicios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.rb1Mes = new System.Windows.Forms.RadioButton();
            this.rb2Meses = new System.Windows.Forms.RadioButton();
            this.rb3Meses = new System.Windows.Forms.RadioButton();
            this.rb12Meses = new System.Windows.Forms.RadioButton();
            this.rb6Meses = new System.Windows.Forms.RadioButton();
            this.cbxImpuestos = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cboServicios
            // 
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Items.AddRange(new object[] {
            "Netflix",
            "ClaroVideo",
            "DisneyPlus"});
            this.cboServicios.Location = new System.Drawing.Point(51, 63);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(206, 28);
            this.cboServicios.TabIndex = 0;
            this.cboServicios.SelectedIndexChanged += new System.EventHandler(this.cboServicios_SelectedIndexChanged);
            // 
            // rb1Mes
            // 
            this.rb1Mes.AutoSize = true;
            this.rb1Mes.Location = new System.Drawing.Point(51, 153);
            this.rb1Mes.Name = "rb1Mes";
            this.rb1Mes.Size = new System.Drawing.Size(69, 24);
            this.rb1Mes.TabIndex = 1;
            this.rb1Mes.TabStop = true;
            this.rb1Mes.Text = "1 Mes";
            this.toolTip2.SetToolTip(this.rb1Mes, "$50");
            this.toolTip3.SetToolTip(this.rb1Mes, "$200");
            this.toolTip1.SetToolTip(this.rb1Mes, "$100");
            this.rb1Mes.UseVisualStyleBackColor = true;
            // 
            // rb2Meses
            // 
            this.rb2Meses.AutoSize = true;
            this.rb2Meses.Location = new System.Drawing.Point(174, 153);
            this.rb2Meses.Name = "rb2Meses";
            this.rb2Meses.Size = new System.Drawing.Size(83, 24);
            this.rb2Meses.TabIndex = 2;
            this.rb2Meses.TabStop = true;
            this.rb2Meses.Text = "2 Meses";
            this.toolTip2.SetToolTip(this.rb2Meses, "$75");
            this.toolTip3.SetToolTip(this.rb2Meses, "$270");
            this.toolTip1.SetToolTip(this.rb2Meses, "$150");
            this.rb2Meses.UseVisualStyleBackColor = true;
            // 
            // rb3Meses
            // 
            this.rb3Meses.AutoSize = true;
            this.rb3Meses.Location = new System.Drawing.Point(51, 183);
            this.rb3Meses.Name = "rb3Meses";
            this.rb3Meses.Size = new System.Drawing.Size(83, 24);
            this.rb3Meses.TabIndex = 3;
            this.rb3Meses.TabStop = true;
            this.rb3Meses.Text = "3 Meses";
            this.toolTip2.SetToolTip(this.rb3Meses, "$130");
            this.toolTip3.SetToolTip(this.rb3Meses, "$350");
            this.toolTip1.SetToolTip(this.rb3Meses, "$250");
            this.rb3Meses.UseVisualStyleBackColor = true;
            // 
            // rb12Meses
            // 
            this.rb12Meses.AutoSize = true;
            this.rb12Meses.Location = new System.Drawing.Point(51, 213);
            this.rb12Meses.Name = "rb12Meses";
            this.rb12Meses.Size = new System.Drawing.Size(91, 24);
            this.rb12Meses.TabIndex = 4;
            this.rb12Meses.TabStop = true;
            this.rb12Meses.Text = "12 Meses";
            this.toolTip2.SetToolTip(this.rb12Meses, "$500");
            this.toolTip3.SetToolTip(this.rb12Meses, "$1000");
            this.toolTip1.SetToolTip(this.rb12Meses, "$950");
            this.rb12Meses.UseVisualStyleBackColor = true;
            // 
            // rb6Meses
            // 
            this.rb6Meses.AutoSize = true;
            this.rb6Meses.Location = new System.Drawing.Point(174, 183);
            this.rb6Meses.Name = "rb6Meses";
            this.rb6Meses.Size = new System.Drawing.Size(83, 24);
            this.rb6Meses.TabIndex = 5;
            this.rb6Meses.TabStop = true;
            this.rb6Meses.Text = "6 Meses";
            this.toolTip2.SetToolTip(this.rb6Meses, "$300");
            this.toolTip3.SetToolTip(this.rb6Meses, "$700");
            this.toolTip1.SetToolTip(this.rb6Meses, "$500");
            this.rb6Meses.UseVisualStyleBackColor = true;
            // 
            // cbxImpuestos
            // 
            this.cbxImpuestos.AutoSize = true;
            this.cbxImpuestos.Location = new System.Drawing.Point(51, 255);
            this.cbxImpuestos.Name = "cbxImpuestos";
            this.cbxImpuestos.Size = new System.Drawing.Size(169, 24);
            this.cbxImpuestos.TabIndex = 6;
            this.cbxImpuestos.Text = "Se cobran impuestos";
            this.cbxImpuestos.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(95, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elige tu servicio de Streaming";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecciona el tiempo de contratación";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxImpuestos);
            this.Controls.Add(this.rb6Meses);
            this.Controls.Add(this.rb12Meses);
            this.Controls.Add(this.rb3Meses);
            this.Controls.Add(this.rb2Meses);
            this.Controls.Add(this.rb1Mes);
            this.Controls.Add(this.cboServicios);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboServicios;
        private RadioButton rb1Mes;
        private RadioButton rb2Meses;
        private RadioButton rb3Meses;
        private RadioButton rb12Meses;
        private RadioButton rb6Meses;
        private CheckBox cbxImpuestos;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
    }
}