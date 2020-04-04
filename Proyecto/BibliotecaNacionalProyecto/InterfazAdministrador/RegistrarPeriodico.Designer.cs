namespace BibliotecaNacionalProyecto.InterfazAdministrador
{
    partial class RegistrarPeriodico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPeriodico));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.volumen = new System.Windows.Forms.TextBox();
            this.editorial = new System.Windows.Forms.Label();
            this.numero_referencia = new System.Windows.Forms.Label();
            this.nombre_periodico = new System.Windows.Forms.TextBox();
            this.titulo_libro = new System.Windows.Forms.Label();
            this.id_periodico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numero_paginas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AceptarIngresoPeriodico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(700, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // volumen
            // 
            this.volumen.Location = new System.Drawing.Point(254, 243);
            this.volumen.Name = "volumen";
            this.volumen.Size = new System.Drawing.Size(207, 20);
            this.volumen.TabIndex = 39;
            // 
            // editorial
            // 
            this.editorial.AutoSize = true;
            this.editorial.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.editorial.Location = new System.Drawing.Point(66, 246);
            this.editorial.Name = "editorial";
            this.editorial.Size = new System.Drawing.Size(63, 17);
            this.editorial.TabIndex = 38;
            this.editorial.Text = "Volumen";
            // 
            // numero_referencia
            // 
            this.numero_referencia.AutoSize = true;
            this.numero_referencia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_referencia.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numero_referencia.Location = new System.Drawing.Point(66, 293);
            this.numero_referencia.Name = "numero_referencia";
            this.numero_referencia.Size = new System.Drawing.Size(138, 17);
            this.numero_referencia.TabIndex = 36;
            this.numero_referencia.Text = "Fecha de publicación";
            // 
            // nombre_periodico
            // 
            this.nombre_periodico.Location = new System.Drawing.Point(254, 196);
            this.nombre_periodico.Name = "nombre_periodico";
            this.nombre_periodico.Size = new System.Drawing.Size(207, 20);
            this.nombre_periodico.TabIndex = 35;
            // 
            // titulo_libro
            // 
            this.titulo_libro.AutoSize = true;
            this.titulo_libro.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_libro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.titulo_libro.Location = new System.Drawing.Point(66, 199);
            this.titulo_libro.Name = "titulo_libro";
            this.titulo_libro.Size = new System.Drawing.Size(144, 17);
            this.titulo_libro.TabIndex = 34;
            this.titulo_libro.Text = "Nombre del periodico";
            // 
            // id_periodico
            // 
            this.id_periodico.Location = new System.Drawing.Point(254, 151);
            this.id_periodico.Name = "id_periodico";
            this.id_periodico.Size = new System.Drawing.Size(207, 20);
            this.id_periodico.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(66, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Id del periodico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(65, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Debe de completar todo los campos requeridos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(64, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Formulario";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // numero_paginas
            // 
            this.numero_paginas.Location = new System.Drawing.Point(254, 338);
            this.numero_paginas.Name = "numero_paginas";
            this.numero_paginas.Size = new System.Drawing.Size(207, 20);
            this.numero_paginas.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(66, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Numero de paginas";
            // 
            // AceptarIngresoPeriodico
            // 
            this.AceptarIngresoPeriodico.Location = new System.Drawing.Point(618, 369);
            this.AceptarIngresoPeriodico.Name = "AceptarIngresoPeriodico";
            this.AceptarIngresoPeriodico.Size = new System.Drawing.Size(110, 23);
            this.AceptarIngresoPeriodico.TabIndex = 31;
            this.AceptarIngresoPeriodico.Text = "Aceptar";
            this.AceptarIngresoPeriodico.UseVisualStyleBackColor = true;
            this.AceptarIngresoPeriodico.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RegistrarPeriodico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(768, 419);
            this.Controls.Add(this.numero_paginas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.volumen);
            this.Controls.Add(this.editorial);
            this.Controls.Add(this.numero_referencia);
            this.Controls.Add(this.nombre_periodico);
            this.Controls.Add(this.titulo_libro);
            this.Controls.Add(this.id_periodico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AceptarIngresoPeriodico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPeriodico";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarPeriodico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox volumen;
        private System.Windows.Forms.Label editorial;
        private System.Windows.Forms.Label numero_referencia;
        private System.Windows.Forms.TextBox nombre_periodico;
        private System.Windows.Forms.Label titulo_libro;
        private System.Windows.Forms.TextBox id_periodico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox numero_paginas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AceptarIngresoPeriodico;
    }
}