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
            Response.Redirect("ComprarExcursion.aspx");
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Agencia a = new Agencia();
            int numExc = Convert.ToInt32(Request.QueryString["Codigo"]);
            int cantMayores = Convert.ToInt32(TxtMayores.Text);
            int cantMenores = Convert.ToInt32(TxtMenores.Text);
            Excursion exc = a.BuscarExcursionEnListaPorCodigo(numExc);
            if (exc.Stock < (cantMayores + cantMenores))
            {
                LiteralMsj.Text = "No hay Stock disponible para la cantidad de personas ingresadas";
            }
            else
            {
                exc.Stock = exc.Stock - (cantMayores + cantMenores);
                List<Excursion> nuevaCompra = new List<Excursion>();
                nuevaCompra.Add(exc);
                LiteralMsj.Text = "Compra realizada";
            }
        }
    }
}