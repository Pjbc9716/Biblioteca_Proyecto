using System;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazUsuario
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro buscaLib = new BusquedaDeLibro();
            buscaLib.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro busqueda = new BusquedaDeLibro();
            busqueda.Show();
            this.Hide();
        }
    }
}
