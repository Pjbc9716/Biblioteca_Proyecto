using System;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazUsuario
{
    public partial class Formulario : Form
    {
        public Formulario(String[] datosRecurso)
        {
            InitializeComponent();
            this.enviar.Enabled = false;
            this.dato1.Text = datosRecurso[0];
            this.dato2.Text = datosRecurso[1];
            this.dato3.Text = datosRecurso[2];
            this.dato4.Text = datosRecurso[3];
            this.dato1.ReadOnly = true;
            this.dato2.ReadOnly = true;
            this.dato3.ReadOnly = true;
            this.dato4.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro buscaLib = new BusquedaDeLibro();
            buscaLib.Show();
            this.Hide();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            String mensaje = "Esta seguro en cerrar esta ventana.\nEl sistema se cerrará";
            String caption = "Cerrando programa...";
            var respuesta = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro busqueda = new BusquedaDeLibro();
            busqueda.Show();
            this.Hide();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {

        }
        public void habilitarButon()
        {
            this.enviar.Enabled = ((!this.cedula.Text.Equals("") && this.cedula.Text.Length >= 8) &&
                !this.nombre.Text.Equals("") && !this.apellido1.Text.Equals("") && !this.apellido2.Text.Equals("")
                && !this.correo.Equals("") && (!this.telefono.Text.Equals("") && this.telefono.Text.Length >= 8));

        }

        private void cedula_TextChanged(object sender, EventArgs e)
        {

            var esNumero = int.TryParse(this.cedula.Text, out int value);
            if (esNumero)
            habilitarButon();
            

            
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            habilitarButon();

        }

        private void apellido1_TextChanged(object sender, EventArgs e)
        {
            habilitarButon();

        }

        private void apellido2_TextChanged(object sender, EventArgs e)
        {
            habilitarButon();

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {
            habilitarButon();

        }

        private void telefono_TextChanged(object sender, EventArgs e)
        {
            habilitarButon();

        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
