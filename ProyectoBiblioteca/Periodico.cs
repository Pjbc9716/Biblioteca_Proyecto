using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Periodico
    {
        // Atributos de la clase Periodico
        private int id_periodico;
        private String nombre_periodico;
        private String volumen;
        private DateTime fecha_publicacion;
        private int numero_paginas;

        // Constructor
        public Periodico(int id_periodico, string nombre_periodico, string volumen, DateTime fecha_publicacion, int numero_paginas)
        {
            this.id_periodico = id_periodico;
            this.nombre_periodico = nombre_periodico;
            this.volumen = volumen;
            this.fecha_publicacion = fecha_publicacion;
            this.numero_paginas = numero_paginas;
        }
    }
}
