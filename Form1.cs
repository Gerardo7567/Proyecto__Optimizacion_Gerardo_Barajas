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
                textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser MAYOR que cero, NO VAC�OS");
                return;
            }
            // Paso 1: Inicializaci�n de par�metros
            int x0 = Convert.ToInt32(textBox1.Text);// x0
            int a = Convert.ToInt32(textBox2.Text); //a
            int c = Convert.ToInt32(textBox3.Text); //m
            int m = Convert.ToInt32(textBox4.Text);//c
            int Total = Convert.ToInt32(textBox5.Text);//total

            // Paso 1.2: Validación algoritmo
            if (x0 < 0 ||
                a <= 0 || c <= 0 ||
                m <= 0)
            {
                MessageBox.Show("Los números tienen que ser MAYORES QUE CERO");
                return;
            }

            // Paso 1.3: m mayor que los demás
            if (m < x0 ||
                m < a ||
                m < c)
            {
                MessageBox.Show("M debe de ser mayor que los demas");
                return;
            }

            // Paso 1.4: Algoritmo rompe cuando el número se repite
            if (m == x0 ||
                m == a ||
                m == c ||
                x0 == a ||
                x0 == c ||
                a == c)
            {
                MessageBox.Show("Los números no se pueden repetir");
                return;
            }
            // Paso 1.5: M no es primo
            bool Primo = true;
            int num = m;
            for (int i = 2; i < num; i++)

            {
                if (num % i == 0)
                {
                    Primo = false;
                    break;
                }
            }
            if (Primo == true)
            {
                // se ejecuta el codigo
            }
            else
            {
                MessageBox.Show("m no es primo");
            }

            // Paso 2: Declarar clase algoritmo gen�tico
            AlgoritmoSimulacion algoritmo = new AlgoritmoSimulacion();
            // Paso 3: Llamar m�todo principal
            List<int> listaEnteros = algoritmo.GenerarValoresPseudoaleatoriosCongruenciales(x0, a, c, m, Total);
            // Paso 4: Llenar el grid
            llenarGrid(listaEnteros);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DescargaExcel(dataGridView1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private int seed = 42; // Initial seed value
        private void button3_Click(object sender, EventArgs e)
        {

            int randomValue1 = GenerateRandomNumber();
            textBox2.Text = randomValue1.ToString();
            int randomValue2 = GenerateRandomNumber();
            textBox3.Text = randomValue2.ToString();
            int randomValue3 = GenerateRandomNumber();
            textBox4.Text = randomValue3.ToString();

        }
        private int GenerateRandomNumber()
        {
            // Square the current seed
            long squaredSeed = (long)seed * seed;

            // Extract the middle digits (in this case, 4 digits)
            string squaredSeedString = squaredSeed.ToString();
            int middleIndex = squaredSeedString.Length / 2 - 2;
            string middleDigits = squaredSeedString.Substring(middleIndex, 4);

            // Update the seed
            seed = int.Parse(middleDigits);

            return seed;
        }

    }
}


