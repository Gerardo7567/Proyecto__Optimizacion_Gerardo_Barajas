using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba16Nov.Algoritmos
{
    public class AlgoritmoSimulacion
    {
        public AlgoritmoSimulacion() { }
        public List<int> GenerarValores(int n)
        {
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < n; i++)
            {
                listaSalida.Add(5 * (i + 1));
            }

            return listaSalida;
        }
        public List<int> GenerarValoresPseudoaleatoriosCongruenciales(int X0, int a, int c, int m, int totalvalores)
        {
            // Paso1: inicializamos valor generado
            int valorgenerado = X0;
            List<int> listaSalida = new List<int>();
            for (int i = 0; i < totalvalores; i++)
            {
                //Paso 2: Calculamos el siguiente valor
                int valorgeneradoaux = (a * valorgenerado + c) % m;
                //Paso 3: guardamos el valor nuevo
                listaSalida.Add(valorgeneradoaux);
                //Paso 4: Seteamos el valor
                valorgenerado = valorgeneradoaux;
            }

            return listaSalida;
        }
    }
}
