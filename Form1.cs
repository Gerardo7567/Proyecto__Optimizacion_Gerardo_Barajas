using Proyecto__Optimizacion_Gerardo_Barajas.Modelos;
using Prueba16Nov.Algoritmos;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto__Optimizacion_Gerardo_Barajas
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }




        public void DescargaExcel(DataGridView data)
        {
            // Paso 0: Instalar complemente de exel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;
            // Paso 1: Construyes columnas y los nombres de las "cabeceras"
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }
            // Paso 2: Construyes filas y llenas valores
            int indiceFilas = 0;

            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            // Paso 3: visibilidad
            exportarExcel.Visible = true;
        }

        public void generarnumerospseudoaleatorios(DataGridView data) { }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Paso 0: Condic�on de vac�o
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") || textBox4.Text.Equals("")||textBox6.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros
            // Paso 1: Inicialización de parámetros
            double a;
            double b;
            int numExperimentos = Convert.ToInt32(textBox4.Text);

            bool CompareInfinityStrings(string input)
            {
                return 
                       input.Trim().Equals("infinity", StringComparison.OrdinalIgnoreCase) ||
                       
                       input.Trim().Equals("-infinity", StringComparison.OrdinalIgnoreCase);
            }

            // Paso 2: Verificación y asignación para 'a'
            if (CompareInfinityStrings(textBox1.Text))
            {
                a = double.NegativeInfinity;
            }
            else if (!double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Por favor ingrese un Limite Inferior aceptable.");
                return;
            }

            // Paso 3: Verificación y asignación para 'b'
            if (CompareInfinityStrings(textBox2.Text))
            {
                b = double.PositiveInfinity;
            }
            else if (!double.TryParse(textBox2.Text, out b))
            {
                MessageBox.Show("Por favor ingrese un Limite Superior aceptable");
                return;
            }

            // Ahora puedes usar 'a' y 'b' según tus necesidades
            if (!double.TryParse(textBox1.Text, out double LimInf) && textBox1.Text.ToLower() != "-infinity")
            {
                MessageBox.Show("Por favor ingrese un Limite Inferior aceptable.");
                return;
            }
            if (!double.TryParse(textBox2.Text, out double LimSup) && textBox2.Text.ToLower() != "infinity")
            {
                MessageBox.Show("Por favor ingrese un Limite Superior aceptable.");
                return;
            }
            else if (textBox1.Text.ToLower() == "-infinity" || textBox2.Text.ToLower() == "infinity")
            {

            }


            // Paso 1.2: Validación algoritmo
            if (a > b)
            {
                MessageBox.Show("El rango no es correcto.");
                return;
            }

            int y = Convert.ToInt32(textBox6.Text);
            if (y != 1 && y !=2 )
            {
                MessageBox.Show("Los números tienen que ser 1 o 2");
                return;
            }
            else
            {

            }
            


            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal
            List<Experimento> listaExperimentos = algoritmo.SimulacionMontecarlo(a, b, numExperimentos);


            double sum = 0;
            List<double> valores = new List<double>();
            foreach (Experimento experimento in listaExperimentos)
            {
                int aleatorio = random.Next(0, numExperimentos - 1);
                double x = experimento.listaValoresPaneles[aleatorio];
                sum += x;
                valores.Add(x);
            }
            List<double> evaluacionesX = CalcularEvaluacionesX(valores, y);


            double sums = 0;
            double mult = 0;
            //List<int> valoresExactos = new List<int>();
            List<double> valoresSumados = new List<double>();
            double division = Math.Abs(a - b) / numExperimentos;

            foreach (var x in evaluacionesX)
            {
                mult = x * division;
                //sums += mult;
                //valoresExactos.Add(x);
                valoresSumados.Add(mult);
            }
            textBox5.Text = division.ToString(); ;
            double desviacionestandar = valoresSumados.Sum();
            textBox3.Text = desviacionestandar.ToString();

            Matriz(valores, evaluacionesX, valoresSumados);
        }


        public void Matriz(List<double> valores, List<double> evaluacionesX, List<double> valoresSumados)
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Experimento", "Experimento");
            dataGridView1.Columns.Add("Valor de x", "Valor de x");

            dataGridView1.Columns.Add("X(i)", "X(i)");
            dataGridView1.Columns.Add("Area actual", "Area actual");


            for (int i = 0; i < valores.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Experimento"].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells["Valor de x"].Value = valores[i].ToString();
                dataGridView1.Rows[i].Cells["X(i)"].Value = evaluacionesX[i].ToString();
                dataGridView1.Rows[i].Cells["Area actual"].Value = valoresSumados[i].ToString();
            }


        }


        public List<double> CalcularEvaluacionesX(List<double> valores,int y)
        {
            List<double> evaluacionesX = new List<double>();
            
            
            // Función a integrar: f(x) = 2 / (e^x + e^(-x))
            Func<double, double> funcB = x => (y / (Math.Exp(x) + Math.Exp(-x)));

            // Puedes ajustar el rango [a, b] según tus necesidades


            foreach (double experimento in valores)
            {
                // Generar una muestra de x_i ~ U(a, b)
                double x = experimento;

                // Evaluar en la función f(x)
                double fx = funcB(x);

                // Agregar la evaluación de x a la lista
                evaluacionesX.Add(fx);
            }

            return evaluacionesX;
        }

        private static Random random = new Random();


        private static double RandomDouble(double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}


