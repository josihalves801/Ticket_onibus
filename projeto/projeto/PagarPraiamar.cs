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

        private DB _banco = new DB();
        public PagarPraiamar()
        {
            InitializeComponent();
            _banco.DBName = "bdd";
            _banco.Conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dim.Value;
            string result1 = maquina1.RealizaVenda(dinheiro);
            
            

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

        private void PagarPraiamar_Load(object sender, EventArgs e)
        {

        }
    }
}
