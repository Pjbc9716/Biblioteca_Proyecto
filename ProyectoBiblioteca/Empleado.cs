using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Empleado
    {
        // Atributos de la clase Empleado
        private int cedula_empleado;
        private String primer_nombre;
        private String segundo_nombre;
        private String primer_apellido;
        private String segundo_apellido;
        private String genero;
        private String tipo_puesto;

        // Constructor
        public Empleado(int cedula_empleado, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, string genero, string tipo_puesto)
        {
            this.cedula_empleado = cedula_empleado;
            this.primer_nombre = primer_nombre;
            this.segundo_nombre = segundo_nombre;
            this.primer_apellido = primer_apellido;
            this.segundo_apellido = segundo_apellido;
            this.genero = genero;
            this.tipo_puesto = tipo_puesto;
        }
    }
}
