using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class ConfirmarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string num = Convert.ToString(Request.QueryString["Codigo"]);
            LiteralCodigo.Text = num;

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioCliente.aspx");
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int numExc = Convert.ToInt32(Request.QueryString["Codigo"]);
            int cantMayores = Convert.ToInt32(TxtMayores.Text);
            int cantMenores = Convert.ToInt32(TxtMenores.Text);
            Excursion exc = Agencia.Instancia.BuscarExcursionEnListaPorCodigo(numExc);
            if (exc.Stock < (cantMayores + cantMenores))
            {
                LiteralMsj.Text = "No hay Stock disponible para la cantidad de personas ingresadas";
            }
            else
            {
                int cantPersonas = cantMayores + cantMenores;
                exc.Stock = exc.Stock - cantPersonas;
                Agencia.Instancia.AgregarCompra(exc);
                Venta v = new Venta(DateTime.Today, cantPersonas);
                v.AgregarVenta(exc);
                Agencia.Instancia.AgregarVenta(v);
                LiteralMsj.Text = "Compra realizada";
                string detalleNuevaCompra = "<table class='table'><tr><th>Código</th><th>Descripción</th><th>Fecha de Inicio</th><th>Stock Disponible</th></tr>";
                foreach (Excursion ex in Agencia.Instancia.ObtenerListaCompras())
                {
                    detalleNuevaCompra += $"<tr><td>{ex.Codigo}</td><td>{ex.Descripcion}</td><td>{ex.FechaIni}</td><td>{ex.Stock}</td></tr>";
                }
                detalleNuevaCompra += "</table>";
                LiteralListaCompras.Text = detalleNuevaCompra;
            }
        }
    }
}