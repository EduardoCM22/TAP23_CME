namespace CaptchaDeImagenes
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
            this.captchaImg1 = new ControlDeUsuario.CaptchaImg();
            this.SuspendLayout();
            // 
            // captchaImg1
            // 
            this.captchaImg1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.captchaImg1.Dificultad = 10;
            this.captchaImg1.Location = new System.Drawing.Point(49, 60);
            this.captchaImg1.Name = "captchaImg1";
            this.captchaImg1.Size = new System.Drawing.Size(640, 230);
            this.captchaImg1.TabIndex = 0;
            this.captchaImg1.Validar += new System.EventHandler<ControlDeUsuario.Validacion>(this.captchaImg1_Validar);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(744, 380);
            this.Controls.Add(this.captchaImg1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlDeUsuario.CaptchaImg captchaImg1;
    }
}

