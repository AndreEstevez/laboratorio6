using System.Diagnostics.Eventing.Reader;

namespace laboratorio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declaramos el vector //

            int[] datos = new int[5];

            //iniciamos con la asignacion de vectores//

            datos[0] = 17;
            datos[1] = 20;
            datos[2] = 66;
            datos[3] = 88;
            datos[4] = 101;

            //mostrar los datos 
            this.mostra_datos.Text = datos[int.Parse(this.in_texto.Text)].ToString();
        }

        private void in_texto_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            // aqui mostramos el tamaño del array
            string[] nombre = { "jose", "pablo", "roniel", "victor", "carlos" };
            this.label1.Text = nombre.Length.ToString();

            //mostrar todos los nombres 
            string listado = "";
            for (int i = 0; i < nombre.Length; i++)
            {
                listado = listado + nombre[i].ToString() + ",";
            }

            this.label2.Text = listado;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public int[,] matriz = new int[3, 3];

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            //Asignamos los valores 
            if (int.TryParse(this.f0c0.Text, out int resultado))
            {
                matriz[0, 0] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 1 y columna 1");
            }
            if (int.TryParse(this.f0c1.Text, out int resultado1))
            {
                matriz[0, 1] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 1 y columna 2");
            }
            if (int.TryParse(this.f0c2.Text, out int resultado2))
            {
                matriz[0, 2] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 1 y columna 2");
            }
            if (int.TryParse(this.f1c0.Text, out int resultado3))
            {
                matriz[1, 0] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 1 y columna 0");
            }
            if (int.TryParse(this.f1c1.Text, out int resultado4))
            {
                matriz[1, 1] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 2 y columna 1");
            }
            if (int.TryParse(this.f1c2.Text, out int resultado5))
            {
                matriz[1, 2] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 1 y columna 2");
            }
            if (int.TryParse(this.f2c0.Text, out int resultado6))
            {
                matriz[2, 0] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 3 y columna 1");
            }
            if (int.TryParse(this.f2c1.Text, out int resultado7))
            {
                matriz[2, 1] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 3 y columna 2");
            }
            if (int.TryParse(this.f2c2.Text, out int resultado8))
            {
                matriz[2, 2] = resultado;
            }

            else
            {
                MessageBox.Show("haz ingresado un dato no numerico,por favor revisa tus datos,revisa tu fila 3 y columna 3");
            }

            //mostrar los datos 
        }

        private void btn_obtener_Click(object sender, EventArgs e)
        {
            int fila = 0;
            if (int.Parse(this.fila.Text) < 3)
            {
                fila = int.Parse(this.fila.Text);
            }

            else
            {

            }

            int columna = 0;
            if (int.Parse(this.columna.Text) < 3)
            {
                columna = int.Parse(this.columna.Text);
            }

            else
            {

            }


            this.resultado.Text = this.matriz[fila, columna].ToString();


        }
    }
}