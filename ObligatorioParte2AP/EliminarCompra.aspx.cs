﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;

namespace ObligatorioParte2AP
{
    public partial class EliminarCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string num = Convert.ToString(Request.QueryString["Codigo"]);
            LtlNumExcursion.Text = num;
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Request.QueryString["Codigo"]);
            foreach (Excursion ex in Agencia.Instancia.ObtenerListaCompras())
            {
                if(ex.Codigo == num)
                {
                    Agencia.Instancia.EliminarCompra(ex);
                    LtlMsjEliminar.Text = "Compra eliminada";
                }
            }
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaDeCompras.aspx");
        }
    }
}