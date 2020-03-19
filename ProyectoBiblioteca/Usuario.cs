using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca
{
    class Usuario
    {
        // Atributos de la clase Usuario
        private int cedula_usuario;
        private String primer_nombre_usuario;
        private String primer_apellido_usuario;
        private String segundo_apellido_usuario;
        private String correo_usuario;
        private int telefono_usuario;
        private String provincia;
        private String canton;
        private String distrito;

        // Constructor
        public Usuario(int cedula_usuario, string primer_nombre_usuario, string primer_apellido_usuario, string segundo_apellido_usuario, string correo_usuario, int telefono_usuario, string provincia, string canton, string distrito)
        {
            this.cedula_usuario = cedula_usuario;
            this.primer_nombre_usuario = primer_nombre_usuario;
            this.primer_apellido_usuario = primer_apellido_usuario;
            this.segundo_apellido_usuario = segundo_apellido_usuario;
            this.correo_usuario = correo_usuario;
            this.telefono_usuario = telefono_usuario;
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
        }
    }
}
