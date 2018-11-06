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
        decimal dinheiro = 0;
        
        public PagarPraiamar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dim.Value;
            string result = maquina1.RealizaVenda(dinheiro);
            MessageBox.Show(result);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //telaInicial telaInicial = new telaInicial();
            //telaInicial.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void lado1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
