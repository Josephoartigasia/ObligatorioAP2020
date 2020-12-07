using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Destino
    {
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int CantDiasDestino { get; set; }
        public float CostoPorDia { get; set; }
        public static float Cotizacion { get; set; }

        public Destino()
        {

        }
        public Destino(string Ciudad, string Pais, int CantDiasDestino, float CostoPorDia)
        {
            this.Ciudad = Ciudad;
            this.Pais = Pais;
            this.CantDiasDestino = CantDiasDestino;
            this.CostoPorDia = CostoPorDia;
        }
    }
}
