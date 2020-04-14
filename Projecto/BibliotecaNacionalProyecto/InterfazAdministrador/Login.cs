using BibliotecaNacionalProyecto.InterfazUsuario;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazAdministrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {


            Database x = new Database();

            String Nombre = usuario.Text;
            String Pwd = contrasena.Text;

            if (!(Database.verificarCredenciales(Nombre, Pwd)))
            {

                MessageBox.Show("Error, Datos incorrectos");
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }


        }

        private void BusquedaDeLibros_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro buscaLib = new BusquedaDeLibro();
            buscaLib.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void usuario_Enter(object sender, EventArgs e)
        {
            if (usuario.Text == "Usuario")
            {
                usuario.Text = "";
                usuario.ForeColor = Color.LightGray;
            }
        }

        private void usuario_Leave(object sender, EventArgs e)
        {
            if (usuario.Text == "")
            {
                usuario.Text = "Usuario";
                usuario.ForeColor = Color.DimGray;
            }

        }

        private void contrasena_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void contrasena_Enter(object sender, EventArgs e)
        {
            if (contrasena.Text == "Contraseña")
            {
                contrasena.Text = "";
                contrasena.ForeColor = Color.LightGray;
                contrasena.UseSystemPasswordChar = true;
            }
        }

        private void contrasena_Leave(object sender, EventArgs e)
        {
            if (contrasena.Text == "")
            {
                contrasena.Text = "Contraseña";
                contrasena.ForeColor = Color.DimGray;
                contrasena.UseSystemPasswordChar = false;
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
