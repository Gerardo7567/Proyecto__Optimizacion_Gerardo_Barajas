﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__Optimizacion_Gerardo_Barajas.Modelos
{
    public class Experimento
    {
        public int idExperimento { get; set; }
        public List<double> listaValoresPaneles { get; set; } = new List<double>();
        public Experimento() { }
        public Experimento(int idExperimento, List<double> listaValoresPaneles)
        {
            this.idExperimento = idExperimento;
            this.listaValoresPaneles = listaValoresPaneles;
        }
    }
}
