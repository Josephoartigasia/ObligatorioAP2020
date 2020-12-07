using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Agencia
    {
        private List<CompaniaAerea> companiaAereas;
        private List<Destino> destinos;
        private List<Excursion> excursiones;

        public Agencia()
        {
            companiaAereas = new List<CompaniaAerea>();
            destinos = new List<Destino>();
            excursiones = new List<Excursion>();
            AgregarExcursionNacionalPrecargada();
            AgregarExcursionInternacionalPrecargada();
        }

        //DESTINO

        public bool AgregarDestinoValidado(Destino d)
        {
            if (ValidarDestino(d))
            {
                destinos.Add(d);
                return true;
            }
            return false;
        }

        public List<Destino> ObtenerListaDestinos()
        {
            return new List<Destino>(destinos);
        }

        public Destino ObtenerUnDestino()
        {
            foreach(Destino d in destinos)
            {
                return d;
            }
            return null;
        }

        public bool ValidarCantDiasDestino(int cantDiasD)
        {
            if (cantDiasD >= 1)
            {
                return true;
            }
            return false;
        }

        public bool ValidarCostoDestino(float costoPorDiaD)
        {
            if (costoPorDiaD > 0)
            {
                return true;
            }
            return false;
        }

        public bool ValidarCiudadDestino(string ciudadDestino)
        {
            if (ciudadDestino.Length >= 3)
            {
                return true;
            }
            return false;
        }

        public bool ValidarPaisDestino(string paisDestino)
        {
            if (paisDestino.Length >= 3)
            {
                return true;
            }
            return false;
        }

        public string ObtenerPaisDestino(string paisDestino)
        {
            return paisDestino;
        }

        public bool ValidarCotizacion(float cotiz)
        {
            if (cotiz > 0)
            {
                return true;
            }
            return false;
        }


        public float ObtenerCostoDolares(float costo, int cantDiasD)
        {
            float costoTotal = costo * Convert.ToSingle(cantDiasD);
            return costoTotal;
        }

        public float ObtenerCostoPesos(float costo, int canDiasD, float cotiz)
        {
            float costoTotalPesos = (costo * cotiz) * Convert.ToSingle(canDiasD);
            return costoTotalPesos;
        }

        public bool ValidarDestino(Destino d)
        {
            if (ValidarCantDiasDestino(d.CantDiasDestino) && ValidarCostoDestino(d.CostoPorDia) && ValidarCiudadDestino(d.Ciudad) && ValidarPaisDestino(d.Pais))
            {
                return true;
            }
            return false;
        }

        //DESTINOS

        //COMPAÑÍA AÉREA

        public bool AgregarCompAereaValidada(CompaniaAerea compA)
        {
            if (ValidarCompaniaAerea(compA))
            {
                companiaAereas.Add(compA);
                return true;
            }
            return false;
        }

        public List<CompaniaAerea> ObtenerCompaniasAereas()
        {
            return new List<CompaniaAerea>(companiaAereas);
        }

        public CompaniaAerea ObtenerUnaCompaniaAerea()
        {
            foreach (CompaniaAerea cA in companiaAereas)
            {
                return cA;
            }
            return null;
        }

        public bool ValidarNombreCompAerea(string nombreCompAerea)
        {
            if (nombreCompAerea.Length > 3)
            {
                return true;
            }
            return false;
        }

        public bool ValidarCodigoCompAerea(int codigoCompAerea)
        {
            if (codigoCompAerea > 0)
            {
                return true;
            }
            return false;
        }

        public bool ValidarPaisCompAerea(string paisCompAerea)
        {
            if (paisCompAerea.Length > 3)
            {
                return true;
            }
            return false;
        }

        public bool ValidarCompaniaAerea(CompaniaAerea compA)
        {
            if(ValidarNombreCompAerea(compA.NombreComp) && ValidarCodigoCompAerea(compA.CodigoComp) && ValidarPaisCompAerea(compA.PaisComp))
            {
                return true;
            }
            return false;
        }

        //EXCURSIONES

        public void AgregarExcursionNacionalPrecargada()
        {

            Destino d1N = new Destino("Salto", "Uruguay", 3, 15);
            AgregarDestinoValidado(d1N);
            Destino d2N = new Destino("Mercedes", "Uruguay", 2, 12);
            AgregarDestinoValidado(d2N);
            Destino d3N = new Destino("Montevideo", "Uruguay", 4, 18);
            AgregarDestinoValidado(d3N);
            Destino d4N = new Destino("Maldonado", "Uruguay", 4, 16);
            AgregarDestinoValidado(d4N);
            Destino d5N = new Destino("Minas", "Uruguay", 3, 15);
            AgregarDestinoValidado(d5N);


            Excursion exc1 = new ExcursionNacional("lalala", DateTime.Parse("2020-05-11"), DateTime.Parse("2020-06-15"), 12, true, true);
            if (exc1.AgregarDestino(d1N) && exc1.AgregarDestino(d5N))
            {
                exc1.Codigo = exc1.Codigo + Excursion.ProxNumCodigo;
                excursiones.Add(exc1);
                Excursion.ProxNumCodigo += 100;
            }

            Excursion exc2 = new ExcursionNacional("lelele", DateTime.Parse("2020-06-16"), DateTime.Parse("2020-06-26"), 12, true, true);
            if (exc2.AgregarDestino(d3N) && exc2.AgregarDestino(d2N) && exc2.AgregarDestino(d5N) && exc2.AgregarDestino(d4N))
            {
                exc2.Codigo = exc2.Codigo + Excursion.ProxNumCodigo;
                excursiones.Add(exc2);
                Excursion.ProxNumCodigo+= 100;
            }

            Excursion exc3 = new ExcursionNacional("lilili", DateTime.Parse("2020-08-25"), DateTime.Parse("2020-09-11"), 12, true, true);
            if (exc3.AgregarDestino(d5N) && exc2.AgregarDestino(d4N) && exc3.AgregarDestino(d2N))
            {
                exc3.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc3);
                Excursion.ProxNumCodigo+= 100;
                
            }
            Excursion exc4 = new ExcursionNacional("lololo", DateTime.Parse("2020-10-25"), DateTime.Parse("2020-11-10"), 12, true, true);
            if (exc4.AgregarDestino(d1N) && exc4.AgregarDestino(d4N))
            {
                exc4.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc4);
                Excursion.ProxNumCodigo +=100;
            }
        }

        public void AgregarExcursionInternacionalPrecargada()
        {

            //crear y agregar al sistema algunos destinos. Que son los que usaremos para pasar a algunas excursion
            Destino d1 = new Destino("Buenos Aires", "Argentina", 3, 100);
            AgregarDestinoValidado(d1);
            Destino d2 = new Destino("Lima", "Peru", 3, 50);
            AgregarDestinoValidado(d2);
            Destino d3 = new Destino("Santiago de Chile", "Chile", 2, 26);
            AgregarDestinoValidado(d3);
            Destino d4 = new Destino("Londres", "Inglaterra", 7, 50);
            AgregarDestinoValidado(d4);
            Destino d5 = new Destino("Los Ángeles", "Estados Unidos", 8, 52);
            AgregarDestinoValidado(d5);

            CompaniaAerea cA1 = new CompaniaAerea("Pluna", 123, "Uruguay");
            AgregarCompAereaValidada(cA1);
            CompaniaAerea cA2 = new CompaniaAerea("American Airlines", 124, "Estados Unidos");
            AgregarCompAereaValidada(cA2);
            CompaniaAerea cA3 = new CompaniaAerea("Aereolíneas Argentinas", 125, "Argentina");
            AgregarCompAereaValidada(cA3);


            Excursion exc5 = new ExcursionInternacional("prueba", DateTime.Parse("2020-07-16"), DateTime.Parse("2020-07-26"), 09, false, cA1);
            if (exc5.AgregarDestino(d1) && exc5.AgregarDestino(d2) && exc5.AgregarDestino(d3))
            {
                exc5.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc5);
                Excursion.ProxNumCodigo += 100;
            }

            Excursion exc6 = new ExcursionInternacional("lalala", DateTime.Parse("2020-08-25"), DateTime.Parse("2020-08-31"), 20, true, cA2);
            if (exc6.AgregarDestino(d1) && exc6.AgregarDestino(d5) && exc6.AgregarDestino(d4))
            {
                exc6.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc6);
                Excursion.ProxNumCodigo += 100;
            }

            Excursion exc7 = new ExcursionInternacional("nenene", DateTime.Parse("2020-11-11") , DateTime.Parse("2020-11-21"), 4, true, cA3);
            if (exc7.AgregarDestino(d2) && exc7.AgregarDestino(d3))
            {
                exc7.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc7);
                Excursion.ProxNumCodigo += 100;
            }

            Excursion exc8 = new ExcursionInternacional("nanana", DateTime.Parse("2020-12-12"), DateTime.Parse("2020-12-23"), 2, true, cA3);
            if (exc8.AgregarDestino(d1) && exc8.AgregarDestino(d2) && exc8.AgregarDestino(d3) && exc8.AgregarDestino(d4) && exc8.AgregarDestino(d5))
            {
                exc8.Codigo += Excursion.ProxNumCodigo;
                excursiones.Add(exc8);
                Excursion.ProxNumCodigo += 100;
            }
        }


        public List<ExcursionNacional> ObtenerExcursionesNacionales()
        {
            List<ExcursionNacional> exc = new List<ExcursionNacional>();
            foreach(Excursion e in excursiones)
            {
                if(e is ExcursionNacional)
                {
                    exc.Add((ExcursionNacional)e);
                }
            }
            return exc;
        }

        public List<ExcursionInternacional> ObtenerExcursionesInternacionales()
        {
            List<ExcursionInternacional> excI = new List<ExcursionInternacional>();
            foreach(Excursion i in excursiones)
            {
                if(i is ExcursionInternacional)
                {
                    excI.Add((ExcursionInternacional)i);
                }
            }
            return excI;
        }

        public Excursion BuscarExcursionEnListaPorCodigo(int xCodigo)
        {
            foreach(Excursion e in excursiones)
            {
                if(e.Codigo == xCodigo)
                {
                    return e;
                }
            }
            return null;
        }

        public List<Destino> BuscarDestinosExcursionNacional(Excursion exc)
        {
            List<Destino> destEx = new List<Destino>();
            foreach(Destino d in destinos)
            {
                if(exc is ExcursionNacional && d.Pais=="Uruguay")
                {
                    destEx.Add(d);
                }
            }
            return destEx;
        }

        public List<Destino> BuscarDestinosExcursionInternacional(Excursion exc)
        {
            List<Destino> destEx = new List<Destino>();
            foreach (Destino d in destinos)
            {
                if (exc is ExcursionInternacional && d.Pais == "Uruguay")
                {
                    destEx.Add(d);
                }
            }
            return destEx;
        }

        public List<Excursion> ObtenerExcursiones()
        {
            return new List<Excursion>(excursiones);
        }
    }
}
