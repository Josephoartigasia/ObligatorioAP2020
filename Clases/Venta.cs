using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Venta
    {
        public DateTime FechaVenta { get; set; }

        public int CantidadPersonas { get; set; }

        private List<Excursion> excursionesVendidas;

        public List<Excursion> Excursion
        {
            get
            {
                return excursionesVendidas;
            }
        }

        public Venta(DateTime FechaVenta, int CantidadPersonas)
        {
            this.FechaVenta = FechaVenta;
            this.CantidadPersonas = CantidadPersonas;
            excursionesVendidas = new List<Excursion>();
        }

        public void AgregarVenta(Excursion e)
        {
            excursionesVendidas.Add(e);
        }
    }
}
