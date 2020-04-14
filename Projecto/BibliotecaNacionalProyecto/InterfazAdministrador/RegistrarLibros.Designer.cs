namespace BibliotecaNacionalProyecto.InterfazAdministrador
{
    partial class RegistrarLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLibros));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id_estado = new System.Windows.Forms.TextBox();
            this.numero_referencia = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.titulo_libro = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.Label();
            this.AceptarIngresoLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(728, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // id_estado
            // 
            this.id_estado.Location = new System.Drawing.Point(265, 297);
            this.id_estado.Name = "id_estado";
            this.id_estado.Size = new System.Drawing.Size(207, 20);
            this.id_estado.TabIndex = 26;
            // 
            // numero_referencia
            // 
            this.numero_referencia.AutoSize = true;
            this.numero_referencia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_referencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numero_referencia.Location = new System.Drawing.Point(77, 300);
            this.numero_referencia.Name = "numero_referencia";
            this.numero_referencia.Size = new System.Drawing.Size(87, 17);
            this.numero_referencia.TabIndex = 25;
            this.numero_referencia.Text = "Id del estado";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(265, 203);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(207, 20);
            this.titulo.TabIndex = 24;
            // 
            // titulo_libro
            // 
            this.titulo_libro.AutoSize = true;
            this.titulo_libro.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_libro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titulo_libro.Location = new System.Drawing.Point(77, 206);
            this.titulo_libro.Name = "titulo_libro";
            this.titulo_libro.Size = new System.Drawing.Size(46, 17);
            this.titulo_libro.TabIndex = 23;
            this.titulo_libro.Text = "Titulo";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(265, 158);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(207, 20);
            this.isbn.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(77, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Debe de completar todo los campos requeridos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Formulario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 28;
            // 
            // editorial
            // 
            this.editorial.AutoSize = true;
            this.editorial.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editorial.Location = new System.Drawing.Point(77, 253);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(63, 17);
            this.editorial.TabIndex = 27;
            this.editorial.Text = "Editorial";
            // 
            // AceptarIngresoLibro
            // 
            this.AceptarIngresoLibro.Location = new System.Drawing.Point(608, 354);
            this.AceptarIngresoLibro.Name = "AceptarIngresoLibro";
            this.AceptarIngresoLibro.Size = new System.Drawing.Size(110, 23);
            this.AceptarIngresoLibro.TabIndex = 32;
            this.AceptarIngresoLibro.Text = "Aceptar";
            this.AceptarIngresoLibro.UseVisualStyleBackColor = true;
            this.AceptarIngresoLibro.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RegistrarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(768, 419);
            this.Controls.Add(this.AceptarIngresoLibro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.id_estado);
            this.Controls.Add(this.numero_referencia);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.titulo_libro);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarLibros";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarLibros";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox id_estado;
        private System.Windows.Forms.Label numero_referencia;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.Label titulo_libro;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label editorial;
        private System.Windows.Forms.Button AceptarIngresoLibro;
    }
}