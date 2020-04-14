using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazAdministrador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(panel1.Width == 200)
            {
                panel1.Width = 38;
            }
            else
            {
                panel1.Width = 200;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox5.Visible = true;
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        public void AbrirForms(object FormVisu)
        {
            if (this.panel5.Controls.Count > 0) 
                this.panel5.Controls.RemoveAt(0);
            Form fh = FormVisu as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel5.Controls.Add(fh);
            this.panel5.Tag = fh;
            fh.Show();
            
        }



        private void VisualizarSoli_Click(object sender, EventArgs e)
        {
            AbrirForms(new Solicitudes());
        }

        private void Devulciones_Click(object sender, EventArgs e)
        {
            AbrirForms(new Devoluciones());
        }

        private void RegistrarArt_Click(object sender, EventArgs e)
        {
            AbrirForms(new RegistrarArticulo());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AbrirForms(new Catalogo());
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AbrirForms(new NoDisponibles());
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AbrirForms(new ReporteDeArticulos());
        }
    }
}
