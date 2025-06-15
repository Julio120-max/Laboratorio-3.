using System.Linq.Expressions;

namespace Laboratorio_3__switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void mostrar()
        {
            switch (cbxactividades.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Ejercicios: \n1-Correr en cinta o fuera de casa.\n2-Saltar la cuerda.", " Categoria Cardio.");
                    break;

                case 1:
                    MessageBox.Show("Ejercicios: \n1-Entrenamiento con pesas.\n2-Calistenia.", " Categoria Fuerza.");
                    break;

                case 2:
                    MessageBox.Show("Ejercicios: \n1-Yoga.\n2-Estiramientos dinámicos.", " Categoria Flexibilidad.");
                    break;

                case 3:
                    MessageBox.Show("Ejercicios: \n11-CrossFit.\n2-Caminar por senderos de montañas.", " Categoria Funcionalidad.");
                    break;

                case 4:
                    MessageBox.Show("Ejercicios: \n1-Taekwondo.\n2-Boxeo", " Categoria Combate.");
                    break;

                default:
                    MessageBox.Show("Por favor seleccione alguna categoria.", " Categoria Desconocida.");
                    break;
            }
        }
        public void salirdetodo()
        {
            this.Close();
        }

        private void btnejercicios_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            salirdetodo();
        }

        public void implementar()
        {
            switch (cbxalimentacion.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Consumir: \n1-Yogurt natural .\n2- 1 Banano.", " Dia: Lunes.");
                    break;

                case 1:
                    MessageBox.Show("Consumir: \n1-Pechuga de pollo. \n2-Espinacas.", "Dia:Martes.");
                    break;

                case 2:
                    MessageBox.Show("Consumir: \n1-Filete de pescado. \n2-Brocoli.", "Dia: Miercoles.");
                    break;

                case 3:
                    MessageBox.Show("Consumir: \n1- 1 manzana.\n2- Gelatina sin azucar ","Dia:Jueves.");
                    break;

                case 4:
                    MessageBox.Show("Consumir: \n1-Carne de res. \n2- Ensalada verde", "Dia:Viernes.");
                    break;

                case 5:
                    MessageBox.Show("Consumir: \n1-Sopa de lentejeas. \n2- Arroz integral", "Dia: Sabado.");
                    break;
                case 6:
                    MessageBox.Show("Consumir: \n1-Pasta con salsa de tomate natural. \n2- Almendras con yogurt", "Dia: Domingo.");
                    break;
                default:
                    MessageBox.Show("Por favor seleccione un dia de el plan de alimentación.", "Plan Desconocido.");
                    break;

            }

        }

        private void btnalimentacion_Click(object sender, EventArgs e)
        {
            implementar();
        }
    }
}
