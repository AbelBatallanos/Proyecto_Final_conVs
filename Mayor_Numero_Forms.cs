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
    public partial class Mayor_Numero_Forms : Form
    {
        funciones_carpeta.Operaciones_Numericas_Abel block_Numero = new funciones_carpeta.Operaciones_Numericas_Abel();
        public Mayor_Numero_Forms()
        {
            InitializeComponent();
        }

        private void Mayor_Numero_Forms_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int datos_textB = int.Parse(textBox1.Text);
            int result = block_Numero.Funcion_Mayor_N(datos_textB);
            label2.Text = result.ToString();
        }
    }
}
