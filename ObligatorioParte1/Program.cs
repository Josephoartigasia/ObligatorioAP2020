using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace ObligatorioParte1
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcion = "";
            do
            {
                Console.WriteLine("MENU\n1-Ingresar Destinos\n2-Mostrar Destinos Ingresados\n3-Mostrar Compañía Aérea\n4-Mostrar Excursiones Nacionales\n5-Mostrar Excursiones Internacionales\n6-Modificar Cotización\n7-Obtener Excursión Nacional por Fecha y Destino\n8-Obtener Excursión Internacional por Fecha y Destino");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1": AgregarDestinos(); break;
                    case "2": MostrarDestinosIngresados(); break;
                    case "3": MostrarCompaniaAerea(); break;
                    case "4": MostrarExcursionesNacionales(); break;
                    case "5": MostrarExcursionesInternacionales(); break;
                    case "6": ModificarCotizacion(); break;
                    case "7": ObtenerExcursionNacionalPorDestinoYFecha(); break;
                    case "8": ObtenerExcursionInternacionalPorDestinoYFecha(); break;
                }

            } while (opcion != "0");
            Console.ReadKey();
        }

        public static void AgregarDestinos()
        {
            Console.WriteLine("AGREGAR DESTINOS");
            Console.WriteLine("Ingresar ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Ingresar país");
            string pais = Console.ReadLine();
            Console.WriteLine("Ingresar cantidad de días en destino");
            int cantDiasDest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar costo por día");
            float costoPorDia = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Ingresar cotización");
            //float cotizacion = Convert.ToSingle(Console.ReadLine());
            Destino d = new Destino(ciudad, pais, cantDiasDest, costoPorDia);
            if (Agencia.Instancia.AgregarDestinoValidado(d))
            {
                Console.WriteLine("Destino agregado");
            }
            else
            {
                Console.WriteLine("Datos incorrectos");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarDestinosIngresados()
        {
            Console.WriteLine("LISTA DE DESTINOS");
            foreach(Destino d in Agencia.Instancia.ObtenerListaDestinos())
            {
                Console.WriteLine("Ciudad: " + d.Ciudad);
                Console.WriteLine("País: " + d.Pais);
                Console.WriteLine("Cantidad de días en destino: " + d.CantDiasDestino);
                Console.WriteLine("Cotización: " + Destino.Cotizacion);
                Console.WriteLine("Costo destino en U$S: "+ Agencia.Instancia.ObtenerCostoDolares(d.CostoPorDia, d.CantDiasDestino));
                Console.WriteLine("Costo destino en $: " + Agencia.Instancia.ObtenerCostoPesos(d.CostoPorDia, d.CantDiasDestino, Destino.Cotizacion));
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarCompaniaAerea()
        {
            foreach(CompaniaAerea compA in Agencia.Instancia.ObtenerCompaniasAereas())
            {
                Console.WriteLine("Nombre: " + compA.NombreComp);
                Console.WriteLine("Código: " + compA.CodigoComp);
                Console.WriteLine("País: " + compA.PaisComp);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarExcursionesNacionales()
        {
            float cstAcumP = 0;
            float cstAcumD = 0;
            Console.WriteLine("LISTA DE EXCURSIONES NACIONALES");
            foreach(Excursion e in Agencia.Instancia.ObtenerExcursionesNacionales())
            {
                Console.WriteLine("Número de excursión: " + e.Codigo);
                Console.WriteLine("Descripción: " + e.Descripcion);
                Console.WriteLine("Fecha de Inicio: " + e.FechaIni.ToShortDateString());
                Console.WriteLine("Fecha de Fin: " + e.FechaFin.ToShortDateString());
                Console.WriteLine("Stock disponible: " + e.Stock);
                Console.WriteLine("Destinos disponibles: ");
                foreach(Destino d in e.Destinos)
                {
                    float cstEnDolares = Agencia.Instancia.ObtenerCostoDolares(d.CostoPorDia, d.CantDiasDestino);
                    float cstEnPesos = Agencia.Instancia.ObtenerCostoPesos(d.CostoPorDia, d.CantDiasDestino, Destino.Cotizacion);
                    Console.WriteLine("Ciudad: " + d.Ciudad);
                    Console.WriteLine("País: " + d.Pais);
                    Console.WriteLine("Cantidad de días en destino: " + d.CantDiasDestino);
                    Console.WriteLine("Costo por persona U$S: " + cstEnDolares);
                    Console.WriteLine("Costo por persona $: " + cstEnPesos);
                    cstAcumP += cstEnPesos;
                    cstAcumD += cstEnDolares;
                }
                Console.WriteLine("El costo total en U$S es: " + cstAcumD);
                Console.WriteLine("El costo total en $ es: " + cstAcumP);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarExcursionesInternacionales()
        {

            float cstAcumP = 0;
            float cstAcumD = 0;
            Console.WriteLine("LISTA DE EXCURSIONES INTERNACIONALES");
            foreach (Excursion i in Agencia.Instancia.ObtenerExcursionesInternacionales())
            {
                Console.WriteLine("Número de excursión: " + i.Codigo);
                Console.WriteLine("Descripción: " + i.Descripcion);
                Console.WriteLine("Fecha de Inicio: " + i.FechaIni.ToShortDateString());
                Console.WriteLine("Fecha de Fin: " + i.FechaFin.ToShortDateString());
                Console.WriteLine("Stock disponible: " + i.Stock);
                Console.WriteLine("Destinos posibles: ");
                foreach (Destino d in i.Destinos)
                {
                    float cstEnDolares = Agencia.Instancia.ObtenerCostoDolares(d.CostoPorDia, d.CantDiasDestino);
                    float cstEnPesos = Agencia.Instancia.ObtenerCostoPesos(d.CostoPorDia, d.CantDiasDestino, Destino.Cotizacion);
                    Console.WriteLine("Ciudad: " + d.Ciudad);
                    Console.WriteLine("País: " + d.Pais);
                    Console.WriteLine("Cantidad de días en destino: " + d.CantDiasDestino);
                    Console.WriteLine("Costo por persona U$S: " + cstEnDolares);
                    Console.WriteLine("Costo por persona $: " + cstEnPesos);
                    cstAcumP += cstEnPesos;
                    cstAcumD += cstEnDolares;
                }
                Console.WriteLine("El costo total en U$S es: " + cstAcumD);
                Console.WriteLine("El costo total en $ es: " + cstAcumP);
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void ModificarCotizacion()
        {
            Console.WriteLine("MODIFICAR COTIZACIÓN: ");
            Console.WriteLine("La cotización actual es: " + Destino.Cotizacion);
            Console.WriteLine("Ingrese cotización: ");
            float cotizacion = Convert.ToSingle(Console.ReadLine());
            if (Agencia.Instancia.ValidarCotizacion(cotizacion))
            {
                Destino.Cotizacion = cotizacion;
                Console.WriteLine("La nueva cotización es: " + Destino.Cotizacion);
            }
            else
            {
                Console.WriteLine("Cotización inválida");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void ObtenerExcursionNacionalPorDestinoYFecha()
        {
            Console.WriteLine("EXCURSIÓN POR DESTINO Y FECHA");
            Console.WriteLine("Ingresar destino deseado");
            string dest = Console.ReadLine();
            Console.WriteLine("Ingresar fecha de inicio");
            DateTime fechaIni = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingresar fecha final");
            DateTime fechaFin = Convert.ToDateTime(Console.ReadLine());
            foreach(Excursion e in Agencia.Instancia.ObtenerExcursionesNacionales())
            {
                foreach(Destino d in e.Destinos)
                {
                    if(dest== d.Ciudad && fechaIni<= e.FechaIni && fechaFin >= e.FechaIni)
                    {
                        Console.WriteLine("Número de excursión: " + e.Codigo);
                        Console.WriteLine("Descripción: " + e.Descripcion);
                        Console.WriteLine("Fecha de Inicio: " + e.FechaIni.ToShortDateString());
                        Console.WriteLine("Fecha de Fin: " + e.FechaFin.ToShortDateString());
                        Console.WriteLine("Stock disponible: " + e.Stock);
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void ObtenerExcursionInternacionalPorDestinoYFecha()
        {
            Console.WriteLine("EXCURSIÓN POR DESTINO Y FECHA");
            Console.WriteLine("Ingresar destino deseado");
            string dest = Console.ReadLine();
            Console.WriteLine("Ingresar fecha de inicio");
            DateTime fechaIni = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar fecha final");
            DateTime fechaFin = DateTime.Parse(Console.ReadLine());
            foreach(Excursion i in Agencia.Instancia.ObtenerExcursionesInternacionales())
            {
                foreach(Destino d in i.Destinos)
                {
                    if(dest== d.Ciudad && fechaIni<= i.FechaIni && fechaFin >= i.FechaIni)
                    {
                        Console.WriteLine("Número de excursión: " + i.Codigo);
                        Console.WriteLine("Descripción: " + i.Descripcion);
                        Console.WriteLine("Fecha de Inicio: " + i.FechaIni.ToShortDateString());
                        Console.WriteLine("Fecha de Fin: " + i.FechaFin.ToShortDateString());
                        Console.WriteLine("Stock disponible: " + i.Stock);
                    }
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}

