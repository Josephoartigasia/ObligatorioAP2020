using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ExcursionNacional: Excursion
    {
        private bool InteresNacional { get; set; }

        private float Descuento { get; set; }

        public ExcursionNacional(string Descripcion, DateTime FechaIni, DateTime FechaFin, int Stock, bool EsNacional, bool InteresNacional, float Descuento) : base(Descripcion, FechaIni, FechaFin, Stock, EsNacional)
        {
            this.InteresNacional = InteresNacional;
            this.Descuento = Descuento;
        }

        public override bool AgregarDestino(Destino d)
        {
            if (d.Pais == "Uruguay")
            {
                base.AgregarDestino(d);
                return true;
            }
            return false;
        }

        public override float CalcularCostoExcursionDolares(Excursion e)
        {
            if (FechaIni >= DateTime.Parse("2020-05-01") && FechaIni <= DateTime.Parse("2020-08-31"))
            {
                float costoSinDescD = base.CalcularCostoExcursionDolares(e);
                float descuentoD = costoSinDescD * Descuento;
                float costoTotalConDescD = costoSinDescD - descuentoD;
                return costoTotalConDescD;
            }
            return base.CalcularCostoExcursionDolares(e);
        }

        public override float CalcularCostoExcursionPesos(Excursion e)
        {
            if(FechaIni>=DateTime.Parse("2020-05-01") && FechaIni <= DateTime.Parse("2020-08-31"))
            {
                float costoSinDescP = base.CalcularCostoExcursionPesos(e);
                float descuentoP = costoSinDescP * Descuento;
                float costoTotalConDescP = costoSinDescP - descuentoP;
                return costoTotalConDescP;
            }
            return base.CalcularCostoExcursionPesos(e);
        }
    }
}
