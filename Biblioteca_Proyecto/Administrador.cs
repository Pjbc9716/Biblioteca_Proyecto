using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Proyecto
{
    class Administrador : Bibliotecologo
    {
        private String id_administrador;
        private String nombre_Usuario;
        private String contrasena_Usuario;
        private DateTime ulitmo_ingreso;

        public Administrador(string id_empleado, string nombre_Usuario, string contrasena_Usuario, DateTime ultimo_Ingreso, string nombre1, 
            string apellido_1, string apellido_2, string correo1, int telefono1, string puesto1, DateTime ingreso_Sistema1) :  base (id_empleado, nombre1, apellido_1, apellido_2, correo1, telefono1, puesto1, ingreso_Sistema1)
        {
            this.id_administrador = id_empleado;
            this.nombre_Usuario = nombre_Usuario;
            this.contrasena_Usuario = contrasena_Usuario;
            this.ulitmo_ingreso = ultimo_Ingreso;
        }
    }
}
