using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Administrador: Empleado // Se llama a la clase padre conocido como Empleado
    {

        // Atributos de la clase Administrador
        private int id_administrador;
        private String username;
        private String contrasena;
        private DateTime ultimo_ingreso;

        // Constructor
        public Administrador(int cedula_empleado, string username, string contrasena, DateTime ultimo_ingreso, string primer_nombre, string segundo_nombre, 
            string primer_apellido, string segundo_apellido, string genero, string tipo_puesto): base (cedula_empleado, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, genero, tipo_puesto)
        {
            this.id_administrador = cedula_empleado;
            this.username = username;
            this.contrasena = contrasena;
            this.ultimo_ingreso = ultimo_ingreso;
        }



    }
}
