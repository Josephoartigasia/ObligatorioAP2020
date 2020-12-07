using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DominioParte2ObAP;

namespace ObligatorioParte2AP
{
    public partial class PagRegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            string cedula = TxtCedula.Text;
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string contrasena = TxtContrasena.Text;
            if(Empresa.Instancia.AgregarUsuario(cedula, nombre, apellido, contrasena))
            {
                LblMsjRegistro.Text = "Usuario ingresado";
                Response.Redirect("PagInicio.aspx");
            }
            else
            {
                LblMsjRegistro.Text = "Datos Incorrectos";
            }

            
        }
    }
}