namespace BibliotecaNacionalProyecto.InterfazAdministrador
{
    partial class RegistrarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarArticulo));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IngresarLibro = new System.Windows.Forms.Button();
            this.IngresarPeriodico = new System.Windows.Forms.Button();
            this.IngresarRevista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(426, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(74, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Elija que tipo de articulo desea ingresar:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // IngresarLibro
            // 
            this.IngresarLibro.Location = new System.Drawing.Point(80, 140);
            this.IngresarLibro.Name = "IngresarLibro";
            this.IngresarLibro.Size = new System.Drawing.Size(75, 23);
            this.IngresarLibro.TabIndex = 23;
            this.IngresarLibro.Text = "Libro";
            this.IngresarLibro.UseVisualStyleBackColor = true;
            this.IngresarLibro.Click += new System.EventHandler(this.IngresarLibro_Click);
            // 
            // IngresarPeriodico
            // 
            this.IngresarPeriodico.Location = new System.Drawing.Point(191, 140);
            this.IngresarPeriodico.Name = "IngresarPeriodico";
            this.IngresarPeriodico.Size = new System.Drawing.Size(75, 23);
            this.IngresarPeriodico.TabIndex = 24;
            this.IngresarPeriodico.Text = "Periodico";
            this.IngresarPeriodico.UseVisualStyleBackColor = true;
            this.IngresarPeriodico.Click += new System.EventHandler(this.IngresarPeriodico_Click);
            // 
            // IngresarRevista
            // 
            this.IngresarRevista.Location = new System.Drawing.Point(306, 140);
            this.IngresarRevista.Name = "IngresarRevista";
            this.IngresarRevista.Size = new System.Drawing.Size(75, 23);
            this.IngresarRevista.TabIndex = 25;
            this.IngresarRevista.Text = "Revista";
            this.IngresarRevista.UseVisualStyleBackColor = true;
            this.IngresarRevista.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RegistrarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(466, 274);
            this.Controls.Add(this.IngresarRevista);
            this.Controls.Add(this.IngresarPeriodico);
            this.Controls.Add(this.IngresarLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarArticulo";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IngresarLibro;
        private System.Windows.Forms.Button IngresarPeriodico;
        private System.Windows.Forms.Button IngresarRevista;
    }
}