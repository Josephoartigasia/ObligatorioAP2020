using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class ListaDeCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string detalleNuevaCompra = "<table class='table'><tr><th>Código</th><th>Descripción</th><th>Fecha de Inicio</th><th>Stock Disponible</th><th>Costo en US$</th><th>Costo en $</th></tr>";
            foreach (Excursion ex in Agencia.Instancia.ObtenerListaCompras())
            {
                foreach (Destino d in ex.Destinos)
                {
                    detalleNuevaCompra += $"<tr><td>{ex.Codigo}</td><td>{ex.Descripcion}</td><td>{ex.FechaIni}</td><td>{ex.Stock}</td><td>{Agencia.Instancia.ObtenerCostoPorTipoExcursionDolares(d.CostoPorDia, d.CantDiasDestino, )}</td> </ tr > ";
                }
            }
            detalleNuevaCompra += "</table>";
            LtlComprasRealizadas.Text = detalleNuevaCompra;
        }

        protected void BtnVolverIniCli_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioCLiente.aspx");
        }
    }
}