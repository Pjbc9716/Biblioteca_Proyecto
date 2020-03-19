using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Libro
    {
        // Atributos de la clase Libro
        private int ISBN;
        private String titulo;
        private String editorial;
        private int id_estado;
        private Boolean condenado;
        private DateTime ultime_consulta;

        //Constructor
        public Libro(int iSBN, string titulo, string editorial, int id_estado, bool condenado, DateTime ultime_consulta)
        {
            ISBN = iSBN;
            this.titulo = titulo;
            this.editorial = editorial;
            this.id_estado = id_estado;
            this.condenado = condenado;
            this.ultime_consulta = ultime_consulta;
        }



    }
}
