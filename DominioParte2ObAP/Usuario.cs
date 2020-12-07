using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioParte2ObAP
{
    public class Usuario
    {
        public string NomUsuario { get; set; }

        public string Contrasena { get; set; }

        public string Rol { get; set; }
        public Usuario(string NomUsuario, string Contrasena, string Rol)
        {
            this.NomUsuario = NomUsuario;
            this.Contrasena = Contrasena;
            this.Rol = Rol;
        }
    }
}
