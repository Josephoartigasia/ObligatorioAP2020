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
            AgregarOperador();
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

        public bool AgregarCliente(string ced, string nom, string ape, string contr)
        {
            Cliente uNuevo = new Cliente(ced, nom, ape, ced, contr, "Cliente");
            if (ValidarCedula(ced) && ValidarNombre(nom) && ValidarApellido(ape) && ValidarContrasena(contr) && !usuarios.Contains(uNuevo))
            {
                usuarios.Add(uNuevo);
                return true;
            }
            return false;
        }

        public void AgregarOperador()
        {
            Usuario operador1 = new Operador("Operador1", "147258", "Operador");
            if(ValidarNombre(operador1.NomUsuario) && ValidarContrasena(operador1.Contrasena) && !usuarios.Contains(operador1))
            {
                usuarios.Add(operador1);
            }
          
            Usuario operador2 = new Operador("Operador2", "258369", "Operador");
            if(ValidarNombre(operador1.NomUsuario) && ValidarContrasena(operador2.Contrasena) && !usuarios.Contains(operador2))
            {
                usuarios.Add(operador2);
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public List<Cliente> ObtenerUsuariosClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            foreach(Usuario u in usuarios)
            {
                if(u is Cliente)
                {
                    clientes.Add((Cliente)u);
                }
            }
            return clientes;
        }
    }
}
