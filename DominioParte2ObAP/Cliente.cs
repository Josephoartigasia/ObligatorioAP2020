using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioParte2ObAP
{
    public class Cliente: Usuario
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente(string Cedula, string Nombre, string Apellido, string NomUsuario, string Contrasena, string Rol) :base(NomUsuario, Contrasena, Rol)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
    }
}
