using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Excursion
    {
        public int Codigo { get; set; } 
        public static int ProxNumCodigo { get; set; } = 1000;
        public string Descripcion { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantDias { get; set; }
        public int Stock { get; set; }
        public bool EsNacional { get; set; }

        private List<Destino> destinosExc;

        public List<Destino> Destinos
        {
            get
            {
                return destinosExc;
            }
        }

        public Excursion(string Descripcion, DateTime FechaIni, DateTime FechaFin, int Stock, bool EsNacional)
        {
            this.Descripcion = Descripcion;
            this.FechaIni = FechaIni;
            this.FechaFin = FechaFin;
            this.Stock = Stock;
            this.EsNacional = EsNacional;
            destinosExc = new List<Destino>();
        }

        public virtual bool AgregarDestino(Destino d)
        {
            //valida que el destino no esté ya
            if (!destinosExc.Contains(d))
            {
                destinosExc.Add(d);
                return true;
            }
            return false;
        }
    }
}
