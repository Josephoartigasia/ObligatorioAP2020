using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ExcursionInternacional : Excursion
    {
        private CompaniaAerea CompAerea { get; set; }

        public static float Comision { get; set; } = 0.05f;

        public ExcursionInternacional(string Descripcion, DateTime FechaIni, DateTime FechaFin, int Stock, bool EsNacional, CompaniaAerea CompAerea): base(Descripcion, FechaIni, FechaFin, Stock, EsNacional)
        {
            this.CompAerea = CompAerea;
        }

        public override bool AgregarDestino(Destino d)
        {
            //valida que el destino no esté ya
            if(d.Pais != "Uruguay")
            {
                base.AgregarDestino(d);
                return true;
            }
            return false;
        }

        public override float CalcularCostoExcursionDolares(Excursion e)
        {
            float costoSinAumD = base.CalcularCostoExcursionDolares(e);
            float aumentoD = costoSinAumD * Comision;
            float costoTotalConAumD = costoSinAumD + aumentoD;
            return costoTotalConAumD;
        }

        public override float CalcularCostoExcursionPesos(Excursion e)
        {
            float costoSinAumP = base.CalcularCostoExcursionPesos(e);
            float aumentoP = costoSinAumP * Comision;
            float costoTotalConAumP = costoSinAumP + aumentoP;
            return costoTotalConAumP;
        }
    }
}
