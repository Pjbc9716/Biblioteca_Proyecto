using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Ticket: Empleado // Se llama a la clase padre conocido como Empleado
    {
    
        // Atributos de la clase Ticket
        private int id_ticket;
        private int id_solicitud;
        private int id_administrador;
        private String id_estado;
        private int hora_solicitud;

        // Constructor
        public Ticket(int id_ticket, int id_solicitud, int cedula_empleado, string id_estado, int hora_solicitud, 
            string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, string genero, string tipo_puesto): base (cedula_empleado, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, genero, tipo_puesto)
        {
            this.id_ticket = id_ticket;
            this.id_solicitud = id_solicitud;
            this.id_administrador = cedula_empleado;
            this.id_estado = id_estado;
            this.hora_solicitud = hora_solicitud;
        }
    }
}
