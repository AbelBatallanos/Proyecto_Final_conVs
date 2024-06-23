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
    public partial class Mover_Mayor_Al_Final : Form
    {
        funciones_carpeta.Operaciones_Numericas_Abel block_Numero = new funciones_carpeta.Operaciones_Numericas_Abel();

        public Mover_Mayor_Al_Final()
        {
            InitializeComponent();
        }

        private void Mover_Mayor_Al_Final_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
            string resultado = block_Numero.mover_Mayor(textBox1.Text);
            label6.Text = resultado;
        }
    }
}
