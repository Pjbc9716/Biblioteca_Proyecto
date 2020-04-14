using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazUsuario
{
    public partial class Resultados : Form
    {

        public Resultados(DataSet ds)
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ds.Tables[0];
            this.identificadortxt.ReadOnly = true;
            numResultados.Text = "# de Resultados: " + ds.Tables[0].Rows.Count;



        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusquedaDeLibro buscaLib = new BusquedaDeLibro();
            buscaLib.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formulario form = new Formulario();
            form.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = this.dataGridView1.Rows[index];
            this.identificadortxt.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void id_solicitud_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
