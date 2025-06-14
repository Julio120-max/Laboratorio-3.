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
    }
}
