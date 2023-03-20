namespace HilosCorredores
{
    partial class Corredores
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
            this.buttonIniciar1 = new System.Windows.Forms.Button();
            this.buttonIniciar2 = new System.Windows.Forms.Button();
            this.buttonIniciar3 = new System.Windows.Forms.Button();
            this.buttonIniciarTodos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIniciar1
            // 
            this.buttonIniciar1.Location = new System.Drawing.Point(57, 288);
            this.buttonIniciar1.Name = "buttonIniciar1";
            this.buttonIniciar1.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar1.TabIndex = 3;
            this.buttonIniciar1.Text = "Iniciar 1";
            this.buttonIniciar1.UseVisualStyleBackColor = true;
            this.buttonIniciar1.Click += new System.EventHandler(this.buttonIniciar1_Click);
            // 
            // buttonIniciar2
            // 
            this.buttonIniciar2.Location = new System.Drawing.Point(148, 288);
            this.buttonIniciar2.Name = "buttonIniciar2";
            this.buttonIniciar2.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar2.TabIndex = 4;
            this.buttonIniciar2.Text = "Iniciar 2";
            this.buttonIniciar2.UseVisualStyleBackColor = true;
            this.buttonIniciar2.Click += new System.EventHandler(this.buttonIniciar2_Click);
            // 
            // buttonIniciar3
            // 
            this.buttonIniciar3.Location = new System.Drawing.Point(243, 288);
            this.buttonIniciar3.Name = "buttonIniciar3";
            this.buttonIniciar3.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar3.TabIndex = 5;
            this.buttonIniciar3.Text = "Iniciar 3";
            this.buttonIniciar3.UseVisualStyleBackColor = true;
            this.buttonIniciar3.Click += new System.EventHandler(this.buttonIniciar3_Click);
            // 
            // buttonIniciarTodos
            // 
            this.buttonIniciarTodos.Location = new System.Drawing.Point(57, 326);
            this.buttonIniciarTodos.Name = "buttonIniciarTodos";
            this.buttonIniciarTodos.Size = new System.Drawing.Size(261, 23);
            this.buttonIniciarTodos.TabIndex = 6;
            this.buttonIniciarTodos.Text = "Iniciar Todos";
            this.buttonIniciarTodos.UseVisualStyleBackColor = true;
            this.buttonIniciarTodos.Click += new System.EventHandler(this.buttonIniciarTodos_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HilosCorredores.Properties.Resources.boy_run;
            this.pictureBox3.Location = new System.Drawing.Point(57, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HilosCorredores.Properties.Resources.girl_run;
            this.pictureBox2.Location = new System.Drawing.Point(57, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HilosCorredores.Properties.Resources.Forest_Corriendo;
            this.pictureBox1.Location = new System.Drawing.Point(57, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Corredores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIniciarTodos);
            this.Controls.Add(this.buttonIniciar3);
            this.Controls.Add(this.buttonIniciar2);
            this.Controls.Add(this.buttonIniciar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Corredores";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonIniciar1;
        private System.Windows.Forms.Button buttonIniciar2;
        private System.Windows.Forms.Button buttonIniciar3;
        private System.Windows.Forms.Button buttonIniciarTodos;
    }
}

