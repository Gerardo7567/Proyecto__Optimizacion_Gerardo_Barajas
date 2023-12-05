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

        public List<int> GenerarValoresPseudoaleatoriosNOCongruenciales(int x, int total)
        {
            List<int> listaSalida = new List<int>();
            

            for (int i = 0; i < total; i++)
            {
                // Paso 2: Calculamos el siguiente valor usando el método del cuadrado medio
                int valorGeneradoAux = CalcularCuadradoMedio(ref x);

                // Paso 3: Verificamos si el valor ya ha sido generado
                if (listaSalida.Contains(valorGeneradoAux))
                {
                    break;
                }

                // Paso 4: Guardamos el valor nuevo
                listaSalida.Add(valorGeneradoAux);

                // Paso 6: Seteamos el siguiente valor
                x = valorGeneradoAux;
            }

            return listaSalida;
        }
        public int CalcularCuadradoMedio(ref int x)
        {
            long cuadrado = (long)x * x;
            string cuadradoStr = cuadrado.ToString();
            int longitud = x.ToString().Length;

            if (cuadradoStr.Length % 2 != 0)
            {
                cuadradoStr = 0 + cuadradoStr;

            }
            // Obtenemos los dígitos centrales
            double resultado = (double)(((cuadradoStr.Length - longitud) / 2 + 1));
            int inicio = (int)Math.Ceiling(resultado);



            string nuevoValorStr = cuadradoStr.Substring(inicio , longitud);

            // Convertimos el nuevo valor a entero
            int nuevoValor = int.Parse(nuevoValorStr);

            // Actualizamos la semilla para la siguiente iteración
            x = nuevoValor;

            return nuevoValor;
        }

        }
    }

    

