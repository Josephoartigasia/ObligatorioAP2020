using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioParte2ObAP
{
    public class Empresa
    {
        private List<Usuario> usuarios;

        private static Empresa instanciaEmpresa = null;
        public static Empresa Instancia
        {
            get
            {
                if (instanciaEmpresa == null)
                {
                    instanciaEmpresa = new Empresa();
                }
                return instanciaEmpresa;
            }
        }

        private Empresa()
        {
            usuarios = new List<Usuario>();
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return new List<Usuario>(usuarios);
            }
        }

        public Usuario BuscarUsuario(string NomUsu, string Contrasena, string xRol)
        {
            foreach(Usuario u in usuarios)
            {
                if(u.NomUsuario == NomUsu && u.Contrasena==Contrasena && u.Rol== xRol)
                {
                    return u;
                }
            }
            return null;
        }

        public bool ValidarCedula(string ced)
        {
            if(ced.Length>6 && ced.Length < 10)
            {
                return true;
            }
            return false;
        }

        public bool ValidarNombre(string nom)
        {
            if (nom.Length >= 2)
            {
                return true;
            }
            return false;
        }

        public bool ValidarApellido(string ape)
        {
            if (ape.Length >= 2)
            {
                return true;
            }
            return false;
        }

        public bool ValidarContrasena(string contr)
        {
            if (contr.Length >= 6)
            {
                return true;
            }
            return false;
        }

        public bool AgregarUsuario(string ced, string nom, string ape, string contr)
        {
            if(ValidarCedula(ced) && ValidarNombre(nom) && ValidarApellido(ape) && ValidarContrasena(contr))
            {
                Usuario uNuevo = new Usuario(ced, contr, "Cliente");
                usuarios.Add(uNuevo);
                return true;
            }
            return false;
        }
    }
}
