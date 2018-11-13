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
    public partial class PagarCentro : Form
    {
        private decimal dinheiro = 0;

        private DB _banco = new DB();
        public PagarCentro()
        {
            InitializeComponent();
            _banco.DBName = "bdd";
            _banco.Conectar();
        }

        private void voltar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok3_Click(object sender, EventArgs e)
        {
            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dimCentro.Value;
            string result3 = maquina1.RealizaVenda3(dinheiro);
            MessageBox.Show(result3);
        }
    }
}
