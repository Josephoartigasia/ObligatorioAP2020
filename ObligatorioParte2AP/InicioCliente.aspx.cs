using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class InicioCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarExcursiones();
            }

        }

        private void ListarExcursiones()
        {
            Agencia a = new Agencia();
            string html = "<table class='table'><tr><th>Código de Excursión</th><th>Descripción</th><th>Fecha de Inicio</th><th>Stock Disponible</th><th></th></tr> ";
            foreach(Excursion e in a.ObtenerExcursiones())
            {
                html += $"<tr><td>{e.Codigo}</td><td>{e.Descripcion}</td><td>{e.FechaIni}</td><td>{e.Stock}</td><td><a href='/ComprarExcursion.aspx?Codigo={e.Codigo}'>Ver</a></td></tr>";
            }
            html += "<table>";
            LiteralTabla.Text = html;
        }
    }
}