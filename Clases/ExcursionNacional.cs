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
    }
}
