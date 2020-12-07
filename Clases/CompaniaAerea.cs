using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CompaniaAerea
    {
        private string nombreComp;
        private int codigoComp;
        private string paisComp;

        public string NombreComp { get; set; }
        public int CodigoComp { get; set; }
        public string PaisComp { get; set; }

        public CompaniaAerea()
        {

        }

        public CompaniaAerea(string NombreComp, int CodigoComp, string PaisComp)
        {
            this.NombreComp = NombreComp;
            this.CodigoComp = CodigoComp;
            this.PaisComp = PaisComp;
        }
    }
}
