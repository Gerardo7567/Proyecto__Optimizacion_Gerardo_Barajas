using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Optimizacion_Gerardo_Barajas.Modelos
{
    public class Evaluacion
    {
        public int idExperimento { get; set; }

        public List<int> listaValoresEvaluacion { get; set; } = new List<int>();

        public Evaluacion() { }

        public Evaluacion(int idExperimento, List<int> listaValoresEvaluacion)
        {
            this.idExperimento = idExperimento;
            this.listaValoresEvaluacion = listaValoresEvaluacion;
        }
    }
}
