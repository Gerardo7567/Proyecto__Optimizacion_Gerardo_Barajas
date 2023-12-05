﻿using Prueba16Nov.Algoritmos;
using System.Windows.Forms;
using static Prueba16Nov.Algoritmos.AlgoritmoSimulacion;

namespace Proyecto__Optimizacion_Gerardo_Barajas
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        public void llenarGrid(List<int> lista)
        {
            // Paso 0: Indicas el número de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";

            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna3, "R^2(n)");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //Paso 2: Recorres el grid para cada fila llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                // Original
                // dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();

                // Modificado para mostrar el cuadrado
                int valorOriginal = lista[i];
                int cuadrado = valorOriginal * valorOriginal;
                //dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = cuadrado.ToString();

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = cuadrado.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i].ToString();
            }

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
            // Paso 0: Condición de vacío
            if (textBox1.Text.Equals("") ||
                //textBox5.Text.Equals("") ||
                textBox5.Text.Equals(""))
            {
                MessageBox.Show("Las entradas tienen que ser MAYOR que cero, NO VACÍOS");
                return;
            }
            // Paso 1: Inicialización de parámetros
            int x0 = Convert.ToInt32(textBox1.Text);
            //int longitud = Convert.ToInt32(textBox2.Text);
            int Total = Convert.ToInt32(textBox5.Text);

            // Paso 1.2: Validación algoritmo
            if (x0 <= 0
                )
            {
                MessageBox.Show("La semilla debe ser MAYOR QUE CERO");
                return;
            }

            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal
            //int semilla = 1234; // Puedes cambiar la semilla según tus necesidades
            //int totalvalores = 10;

            List<int> listaEnteros = algoritmo.GenerarValoresPseudoaleatoriosNOCongruenciales(x0, Total);
            // Paso 4: Llenar el grid
            llenarGrid(listaEnteros);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


