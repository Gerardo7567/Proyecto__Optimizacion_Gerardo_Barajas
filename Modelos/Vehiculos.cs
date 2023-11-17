using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Optimizacion_Gerardo_Barajas.Modelos
{
    public class Vehiculos
    {
        public double Capacidad { get; set; }
        public long LatitudOrigenCondicionInicial { get; set; }
        public long LongitudOrigenCondicionInicial { get; set; }

        public List<Demanda> ListaAsignaciones { get; set; }=new List<Demanda>();

        public DateTime FechaDisponible { get; set; } = DateTime.Now;

        public Vehiculos() { }
        public Vehiculos(double capacidad, long latitudOrigenCondicionInicial, long longitudOrigenCondicionInicial, List<Demanda> listaAsignaciones, DateTime fechaDisponible)
        {
            Capacidad = capacidad;
            LatitudOrigenCondicionInicial = latitudOrigenCondicionInicial;
            LongitudOrigenCondicionInicial = longitudOrigenCondicionInicial;
            ListaAsignaciones = listaAsignaciones;
            FechaDisponible = fechaDisponible;
        }
    }
}
