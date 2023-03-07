namespace PruebaSelector
{
    partial class Form1
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
            this.selectorDeMes1 = new ControlesEjercicio.SelectorDeMes();
            this.SuspendLayout();
            // 
            // selectorDeMes1
            // 
            this.selectorDeMes1.Location = new System.Drawing.Point(276, 203);
            this.selectorDeMes1.Mes = ControlesEjercicio.Months.Mayo;
            this.selectorDeMes1.Name = "selectorDeMes1";
            this.selectorDeMes1.Size = new System.Drawing.Size(207, 42);
            this.selectorDeMes1.TabIndex = 0;
            this.selectorDeMes1.Valor = 5;
            this.selectorDeMes1.Change += new System.EventHandler<ControlesEjercicio.ChangeSelectorArgs>(this.selectorDeMes1_Change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectorDeMes1);
            this.Name = "Form1";
            this.Text = "Eduardo Campos Manriquez";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesEjercicio.SelectorDeMes selectorDeMes1;
    }
}

