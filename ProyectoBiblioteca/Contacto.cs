using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Contacto: Empleado // Se llama a la clase padre conocido como Empleado
    {
        // Atributos de la clase Contrato
        private int cedula_empleado;
        private String contacto;
        private String tipo_contacto;

        // Constructor
        public Contacto(int cedula_empleado, string contacto, string tipo_contacto, string primer_nombre, string segundo_nombre, 
            string primer_apellido, string segundo_apellido, string genero, string tipo_puesto): base (cedula_empleado, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, genero, tipo_puesto)
        {
            this.cedula_empleado = cedula_empleado;
            this.contacto = contacto;
            this.tipo_contacto = tipo_contacto;
        }
    }
}
