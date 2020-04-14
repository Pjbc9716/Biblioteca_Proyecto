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
    public partial class RegistrarArticulo : Form
    {
        public RegistrarArticulo()
        {
            InitializeComponent();
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RegistrarRevista rr = new RegistrarRevista();
            rr.Show();
            this.Hide();
        }

        private void IngresarLibro_Click(object sender, EventArgs e)
        {
            RegistrarLibros rl = new RegistrarLibros();
            rl.Show();
            this.Hide();
        }

        private void IngresarPeriodico_Click(object sender, EventArgs e)
        {
            RegistrarPeriodico ra = new RegistrarPeriodico();
            ra.Show();
            this.Hide();
        }
    }
}
