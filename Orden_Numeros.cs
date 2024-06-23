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
    public partial class Orden_Numeros : Form
    {
        funciones_carpeta.Operaciones_Numericas_Abel block_Numero = new funciones_carpeta.Operaciones_Numericas_Abel();

        public Orden_Numeros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text
            bool resultado = block_Numero.order_number(textBox1.Text);
            if (resultado)
            {
                label3.Text = "los digitos están ordenados";
            }
            else
            {
                label3.Text = "los digitos no están ordenados";

            }
        }
    }
}
