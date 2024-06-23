using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Cumbre
{
    public partial class Cantidad_Impares_antes_Pares : Form
    {
        funciones_carpeta.Operaciones_Numericas_Abel block_Numero = new funciones_carpeta.Operaciones_Numericas_Abel();

        public Cantidad_Impares_antes_Pares()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Digit_Ingresados.Text = textBox1.Text;
            int resultado = block_Numero.contador_Cantidad_impares(textBox1.Text);
            label4.Text = "Se encontraron:"+" "+resultado.ToString() ;
            //Creando_Rm2_Git
        }
    }
}
