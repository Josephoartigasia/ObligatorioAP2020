using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DominioParte2ObAP;

namespace ObligatorioParte2AP
{
    public partial class ListaDeClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarUsuarios();
            }
        }

        private void ListarUsuarios()
        {
            List<Cliente> usuarios = new List<Cliente>();
            usuarios = Empresa.Instancia.ObtenerUsuariosClientes();
            string html = "<table class='table'><tr><th>Apellido</th><th>Nombre</th><th>Cédula</th></tr> ";
            foreach (Cliente u in usuarios)
            {
                html += $"<tr><td>{u.Apellido}</td><td>{u.Nombre}</td><td>{u.Cedula}</td>";
            }
            html += "<table>";
            LtlUsuariosRegistrados.Text = html;
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioOperador.aspx");
        }
    }
}