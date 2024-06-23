using System.DirectoryServices.ActiveDirectory;

namespace Proyecto_Final_Cumbre
{
    public partial class Form1 : Form
    {
        Mayor_Numero_Forms foms_M_Num = new Mayor_Numero_Forms();
        Sum_Pares fonms_Sum_Pares = new Sum_Pares();
        Mover_Mayor_Al_Final fonms_Mv_Mayor_End = new Mover_Mayor_Al_Final();
        Orden_Numeros fonms_Orden_Numeros = new Orden_Numeros();
        Cantidad_Impares_antes_Pares fonms_ejercicio_5 = new Cantidad_Impares_antes_Pares();
        public Form1()
        {
            InitializeComponent();
            //Cambio 1
        }

        private void mayorNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foms_M_Num.Show();
        }

        private void sumaparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonms_Sum_Pares.Show();
        }

        private void moverMayorAlFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonms_Mv_Mayor_End.Show();
        }

        private void numeroOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonms_Orden_Numeros.Show();
        }

        private void contadorCantImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fonms_ejercicio_5.Show();   
            //creando_Rm2_Git
            //Tercera_Modific

            //Haciendo un push con la rama 3
        }
    }
}
