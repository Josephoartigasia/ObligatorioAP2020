using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            string destino = TxtDestino.Text;
            string html = "<table class='table'><tr><th>Fecha de Inicio</th><th>Código</th><th>Descripción</th><th>Stock Disponible</th></tr> ";
            foreach (Excursion ex in Agencia.Instancia.ObtenerExcursiones())
            {
                if (Agencia.Instancia.BuscarExcursionPorDestino(destino)==ex.ObtenerNombreDestinos(destino))
                {
                    html += $"<tr><td>{ex.FechaIni.ToShortDateString()}</td><td>{ex.Codigo}</td><td.{ex.Descripcion}</td><td>{ex.Stock}</td></tr>";
                }
                else
                {
                    html = "No existen Excursiones con dicho Destino";
                }
            }
            html += "</table>";
            LiteralExcursionesPorDestino.Text = html;
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioOperador.aspx");
        }

        protected void BtnDestMasExc_Click(object sender, EventArgs e)
        {
        }
    }
}