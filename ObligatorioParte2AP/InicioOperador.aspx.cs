using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatorioParte2AP
{
    public partial class InicioOperador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaDeClientes.aspx");
        }

        protected void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estadisticas.aspx");
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("PagInicio.aspx");
        }

        protected void BtnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("VentasRealizadas.aspx");
        }
    }
}