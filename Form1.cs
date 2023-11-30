using Proyecto__Optimizacion_Gerardo_Barajas.Modelos;
using Prueba16Nov.Algoritmos;
using System.Windows.Forms;

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
                textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int numPaneles = Convert.ToInt32(textBox3.Text);
            int numExperimentos = Convert.ToInt32(textBox4.Text);



            // Paso 1.2: Validación algoritmo
            if (numPaneles <= 0 || numExperimentos <= 0)
            {
                MessageBox.Show("Los números tienen que ser MAYORES QUE CERO");
                return;
            }

            // Paso 1.3: Validación algoritmo
            if (a > b)
            {
                MessageBox.Show("El rango no es correcto.");
                return;
            }


            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal
            List<Experimento> listaExperimentos = algoritmo.SimulacionMontecarlo(a, b, numPaneles, numExperimentos);

            // calculo de promedio
            double sum = 0;
            Random random = new Random();
            List<int> valores = new List<int>();
            foreach (Experimento experimento in listaExperimentos)
            {
                int aleatorio = random.Next(0, numPaneles - 1);
                int x = experimento.listaValoresPaneles[aleatorio];
                sum += x;
                valores.Add(x);
            }

            double promedio = sum / numExperimentos;
            textBox5.Text = promedio.ToString();

            //calculo de desviacion estandar
            double sums = 0;
            foreach (int x in valores)
            {
                sums += Math.Pow(x - promedio, 2);
            }
            double desviacionestandar = Math.Sqrt(sums / numExperimentos);
            textBox6.Text = desviacionestandar.ToString();


            // Paso 4: Llenar el grid
            Matriz(listaExperimentos, valores);
        }
        public void Matriz(List<Experimento> listaExperimentos, List<int> valores)
        {
            int numPaneles = listaExperimentos[0].listaValoresPaneles.Count;
            List<string> nombresColumnas = new List<string>();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Experimento", "Experimento");
            for (int i = 0; i < numPaneles; i++)
            {
                nombresColumnas.Add(i.ToString());
                dataGridView1.Columns.Add(nombresColumnas[i], "Panel" + (i + 1).ToString());
            }
            dataGridView1.Columns.Add("X(i)", "X(i)");

            for (int i = 0; i < listaExperimentos.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Experimento"].Value = (i + 1).ToString();
                for (int j = 0; j < numPaneles; j++)
                {
                    int x = listaExperimentos[i].listaValoresPaneles[j];
                    dataGridView1.Rows[i].Cells[Int32.Parse(nombresColumnas[j]) + 1].Value = x.ToString();
                }
                dataGridView1.Rows[i].Cells["X(i)"].Value = valores[i].ToString();
            }
        }

        public void llenarGrid(List<int> lista)
        {

            // Paso 0: Indicas el n�mero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";

            // Paso 1: Determinas la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //Paso 2: Recorres el grid para cada fila llenas los valores aleatorios
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


