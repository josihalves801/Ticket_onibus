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
    public partial class PagarPraiamar : Form
    {
        public PagarPraiamar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("falta 1 real");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telaInicial telaInicial = new telaInicial();
            telaInicial.ShowDialog();
        }
    }
}
