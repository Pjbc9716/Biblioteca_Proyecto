using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteca_Proyecto
{
    class Bibliotecologo
    {
        private String id_empleado;
        private String nombre;
        private String apellido2;
        private String apellido1;
        private String correo;
        private int telefono;
        private String puesto;
        private DateTime ingreso_Sistema;

        public Bibliotecologo(string id_empleado,string nombre1, string apellido_1, string apellido_2, string correo1, int telefono1, string puesto1, DateTime ingreso_Sistema1)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre1;
            this.apellido1 = apellido_1;
            this.apellido2 = apellido_2;
            this.correo = correo1;
            this.telefono = telefono1;
            this.puesto = puesto1;
            this.ingreso_Sistema = ingreso_Sistema1;
        }


    }
}
