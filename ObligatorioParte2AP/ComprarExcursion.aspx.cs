using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class ComprarExcursion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DetalleExcursión();
            }
        }

        public void DetalleExcursión()
        {
            int num = Convert.ToInt32(Request.QueryString["Codigo"]);
            Excursion e = Agencia.Instancia.BuscarExcursionEnListaPorCodigo(num);
            if (e == null)
            {
                LiteralDetalle.Text = "No existe Excursión";
            }
            else
            {
                string detalle = "<table class='table'><tr><th>Código</th><th>Descripción</th><th>Fecha de Inicio</th><th>Stock Disponible</th></tr>";
                detalle += $"<tr><td>{e.Codigo}</td><td>{e.Descripcion}</td><td>{e.FechaIni.ToShortDateString()}</td><td>{e.Stock}</td><td><a href='/ConfirmarCompra.aspx?Codigo={e.Codigo}'>CONFIRMAR</a></td></tr></table>";
                LiteralDetalle.Text = detalle;
                string detalleDestino = "<table class='table'><tr><th>Ciudad</th><th>País</th><th>Días en Destino</th><th>Costo U$S</th><th>Costo $</th>";
                foreach(Destino d in e.Destinos)
                {
                    detalleDestino += $"<tr><td>{d.Ciudad}</td><td>{d.Pais}</td><td>{d.CantDiasDestino}</td><td>{Agencia.Instancia.ObtenerCostoDolares(d.CostoPorDia, d.CantDiasDestino)}</td><td>{Agencia.Instancia.ObtenerCostoPesos(d.CostoPorDia, d.CantDiasDestino, Destino.Cotizacion)}</td></tr>";
                }
                detalleDestino += "</table>";
                LiteralDestinos.Text = detalleDestino;
            }
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioCliente.aspx");
        }
    }
}