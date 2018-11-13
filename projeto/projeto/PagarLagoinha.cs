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
    public partial class PagarLagoinha : Form
    {
        private decimal dinheiro = 0;
        private DB _banco = new DB();
        public PagarLagoinha()
        {
            InitializeComponent();
            _banco.DBName = "bdd";
            _banco.Conectar();
        }

        private void dimLago_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void voltar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok2_Click(object sender, EventArgs e)
        {
            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dimLago.Value;
            string result2 = maquina1.RealizaVenda2(dinheiro);
            MessageBox.Show(result2);
        }
    }
}
