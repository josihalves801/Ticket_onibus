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
            MessageBox.Show("Insira R$4,95");
        }

        private void centro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("insira 8,90");
        }
    }
}
