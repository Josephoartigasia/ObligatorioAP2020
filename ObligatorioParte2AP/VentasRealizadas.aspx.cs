using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class VentasRealizadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            float acum = 0;
            DateTime fechaIni = DateTime.Parse(TxtFechaIni.Text);
            DateTime fechaFin = DateTime.Parse(TxtFechaFin.Text);
            string html = "<table class='table'><tr><th>Código</th><th>Descripción</th><th>Fecha de Inicio</th><th>Cantidad de Pasajeros</th><th>Monto</th></tr> ";
            foreach (Venta a in Agencia.Instancia.ObtenerListaVentas())
            {
                if(fechaIni<=a.FechaVenta && fechaFin >= a.FechaVenta)
                {
                    foreach(Excursion ex in a.Excursion)
                    {
                        html += $"<tr><td>{ex.Codigo}</td><td>{ex.Descripcion}</td><td>{ex.FechaIni}</td><td>{a.CantidadPersonas}</td><td>{ex.CalcularCostoExcursionPesos(ex)}</td></tr>";
                        acum += ex.CalcularCostoExcursionPesos(ex);
                    }
                }
                else
                {
                    LiteralListaVentas.Text = "No existen ventas en dicho período";
                }
            }
            html += "</table>";
            LiteralListaVentas.Text = html;
            LiteralMontoTotal.Text = Convert.ToString(acum);
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioOperador.aspx");
        }
    }
}