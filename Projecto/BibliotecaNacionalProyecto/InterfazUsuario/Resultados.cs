using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaNacionalProyecto.InterfazUsuario
{
    public partial class Resultados : Form
    {
        int posicionSeleccionada = -1;
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
            if (posicionSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un recurso", "Falta de información", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[posicionSeleccionada];
                String mensaje = "Esta seguro de solicitar el recurso: \n" + selectedRow.Cells[1].Value.ToString();
                var respuesta = MessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (respuesta == DialogResult.Yes)
                {
                    String[] datosRecurso = new string[4];
                    for (int i = 0; i < datosRecurso.Length; i++)
                    {
                        datosRecurso[i] = selectedRow.Cells[i].Value.ToString();
                    }
                    Formulario form = new Formulario(datosRecurso);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    this.identificadortxt.Text = "";
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicionSeleccionada = e.RowIndex;
            DataGridViewRow selectedRow = this.dataGridView1.Rows[posicionSeleccionada];
            this.identificadortxt.Text = selectedRow.Cells[1].Value.ToString();
        }


        private void id_solicitud_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void numResultados_Click(object sender, EventArgs e)
        {

        }
    }
}
