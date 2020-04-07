using BibliotecaNacionalProyecto.InterfazAdministrador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazUsuario
{
    public partial class BusquedaDeLibro : Form
    {
        List<System.Windows.Forms.CheckBox> listaChecks;
        List<System.Windows.Forms.TextBox> listaFiltros;

        public BusquedaDeLibro()
        {
            InitializeComponent();
            this.ordenamientoInicial();
        }

        private void ordenamientoInicial()
        {
            this.filtrocmb.Visible = false;

            this.checkBox2.Visible = false;
            this.opcion1txt.Visible = false;
            this.checkBox2.Location = new System.Drawing.Point(177, 200);
            this.opcion1txt.Location = new System.Drawing.Point(250, 200);

            this.checkBox3.Visible = false;
            this.opcion2txt.Visible = false;
            this.checkBox3.Location = new System.Drawing.Point(177, 230);
            this.opcion2txt.Location = new System.Drawing.Point(250, 230);

            this.checkBox4.Visible = false;
            this.opcion3txt.Visible = false;
            this.checkBox4.Location = new System.Drawing.Point(177, 260);
            this.opcion3txt.Location = new System.Drawing.Point(250, 260);

            this.checkBox5.Visible = false;
            this.opcion4txt.Visible = false;
            this.checkBox5.Location = new System.Drawing.Point(177, 290);
            this.opcion4txt.Location = new System.Drawing.Point(250, 290);

            this.dateTimePicker.Visible = false;
            this.dateTimePicker.Location = new System.Drawing.Point(250, 290);

            this.buscarBtn.Visible = false;
            this.buscarBtn.Location = new System.Drawing.Point(365, 315);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.button1.Text);
            Resultados res = new Resultados(Database.busquedaGeneral(this.button1.Text.ToUpper()));
            this.Hide();
            res.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resultados res = new Resultados(Database.busquedaGeneral(this.button2.Text.ToUpper()));
            this.Hide();
            res.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.checkBox1.Location = this.button1.Location;
                this.filtrocmb.Visible = true;
                this.filtrocmb.Location = new System.Drawing.Point(177, 163);


                this.button1.Visible = false;
                this.button2.Visible = false;
                this.button3.Visible = false;

                this.listaChecks = new List<System.Windows.Forms.CheckBox>();
                this.listaChecks.Add(this.checkBox2);
                this.listaChecks.Add(this.checkBox3);
                this.listaChecks.Add(this.checkBox4);
                this.listaChecks.Add(this.checkBox5);

            }
            else
            {
                this.checkBox1.Location = new System.Drawing.Point(177, 193);
                this.filtrocmb.Visible = false;

                this.checkBox2.Visible = false;
                this.checkBox3.Visible = false;
                this.checkBox4.Visible = false;
                this.checkBox5.Visible = false;

                this.dateTimePicker.Visible = false;

                this.opcion1txt.Visible = false;
                this.opcion2txt.Visible = false;
                this.opcion3txt.Visible = false;
                this.opcion4txt.Visible = false;
                this.buscarBtn.Visible = false;

                this.button1.Visible = true;
                this.button2.Visible = true;
                this.button3.Visible = true;

                this.listaChecks.Clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opcion No Habilitada");

        }

        private void closeBox_Click(object sender, EventArgs e)
        {

            String mensaje = "Esta segura en cerrar esta ventana.";
            String caption = "Cerrando programa...";
            var respuesta = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maximizeBox_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.opcion1txt.Visible = true;
            }
            else
            {
                this.opcion1txt.Text = "Ingrese dato";
                this.opcion1txt.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.opcion2txt.Visible = true;
            }
            else
            {
                this.opcion2txt.Text = "Ingrese dato";
                this.opcion2txt.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                this.opcion3txt.Visible = true;
            }
            else
            {
                this.opcion3txt.Text = "Ingrese dato";
                this.opcion3txt.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                if (this.checkBox5.Text.Equals("Editorial"))
                {
                    this.opcion4txt.Visible = true;
                }
                else
                {
                    this.dateTimePicker.Visible = true;
                }

            }
            else
            {
                this.opcion4txt.Text = "Ingrese dato";
                this.opcion4txt.Visible = false;
                this.dateTimePicker.Visible = false;
            }
        }

        private void filtrocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filtrocmb.SelectedItem.Equals("Libro"))
            {
                this.buscarBtn.Visible = true;
                this.checkBox2.Text = "ISBN";
                this.checkBox2.Visible = true;
                this.checkBox3.Text = "Autor";
                this.checkBox3.Visible = true;
                this.checkBox4.Text = "Titulo";
                this.checkBox4.Visible = true;
                this.checkBox5.Text = "Editorial";
                this.checkBox5.Visible = true;

            }
            else if (this.filtrocmb.SelectedItem.Equals("Periodico"))
            {
                this.buscarBtn.Visible = true;
                this.checkBox2.Text = "Titulo";
                this.checkBox2.Visible = true;
                this.checkBox3.Text = "Prensa";
                this.checkBox3.Visible = true;
                this.checkBox4.Text = "# Edicion";
                this.checkBox4.Visible = true;
                this.checkBox5.Text = "Fecha";
                this.checkBox5.Visible = true;
            }
            else if (this.filtrocmb.SelectedItem.Equals("Revista"))
            {
                this.buscarBtn.Visible = false;
                this.checkBox2.Visible = false;
                this.checkBox3.Visible = false;
                this.checkBox4.Visible = false;
                this.checkBox5.Visible = false;
                MessageBox.Show("No hay recursos", "Opcion Invalida",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void VisualizarSoli_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            listaFiltros = new List<System.Windows.Forms.TextBox>();
            for (int i = 0; i < this.listaChecks.Count; i++)
            {
                if (listaChecks[i].Checked)
                {
                    switch (listaChecks[i].Name.ToString())
                    {
                        case "checkBox2":
                            listaFiltros.Add(this.opcion1txt);
                            break;
                        case "checkBox3":
                            listaFiltros.Add(this.opcion2txt);
                            break;
                        case "checkBox4":
                            listaFiltros.Add(this.opcion3txt);
                            break;
                        case "checkBox5":
                            listaFiltros.Add(this.opcion4txt);
                            break;
                    }
                }
            }
            if (listaFiltros.Count == 0)
            {
                MessageBox.Show("Seleccion un filtro", "Falta informacion", MessageBoxButtons.OK);
            }
            else
            {
                Resultados res = new Resultados(Database.busquedaAvanzada(this.filtrocmb.SelectedItem.ToString().ToUpper(), this.listaFiltros));
                this.listaFiltros.Clear();
                this.Hide();
                res.Show();

            }
        }

    }
}
