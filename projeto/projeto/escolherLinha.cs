using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class escolherLinha : Form
    {
        public escolherLinha()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagar_Lagoinha lagoinha = new Pagar_Lagoinha();
            lagoinha.ShowDialog();
        }

        private void centro_Click(object sender, EventArgs e)
        {
            PagarCentro centro = new PagarCentro();
            centro.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PagarSebastiao form7 = new PagarSebastiao();
            form7.ShowDialog();
        }
    }
}
