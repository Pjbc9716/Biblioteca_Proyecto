using System;

namespace BibliotecaNacionalProyecto
{
    public class Libro
    {
        // Atributos de la clase Libro
        private int ISBN { get; set; }
        private String titulo { get; set; }
        private String editorial { get; set; }
        private int id_estado { get; set; }
        private Boolean condenado { get; set; }
        private DateTime ultime_consulta { get; set; }

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
        public Libro(int isbn)
        {
            this.ISBN = isbn;
        }

    }
}
