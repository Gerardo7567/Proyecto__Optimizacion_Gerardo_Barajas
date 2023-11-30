using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Optimizacion_Gerardo_Barajas.Modelos
{
    public class Experimento
    {
        public int idExperimento { get; set; }
        public List<int> listaValoresPaneles { get; set; } = new List<int>();
        public Experimento() { }
        public Experimento(int idExperimento, List<int> listaValoresPaneles)
        {
            this.idExperimento = idExperimento;
            this.listaValoresPaneles = listaValoresPaneles;
        }
    }
}
