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
    public partial class Sum_Pares : Form
    {
        funciones_carpeta.Operaciones_Numericas_Abel block_Numero = new funciones_carpeta.Operaciones_Numericas_Abel();

        public Sum_Pares()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int date_user = int.Parse(textBox1.Text);
            int resultado = block_Numero.suma_Pares(date_user);
            label1.Text = resultado.ToString();
        }
    }
}
