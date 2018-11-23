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
    public partial class telaInicial : Form
    {
        PagarPraiamar form2 = new PagarPraiamar();


        private DB _banco = new DB();
        public telaInicial()
        {
            InitializeComponent();
            _banco.DBName = "bdd";
            _banco.Conectar();
        }

        private void litoranea_Click(object sender, EventArgs e)
        {
            escolherLinha form3 = new escolherLinha();
            form3.ShowDialog();

        }

        private void praiamar_Click(object sender, EventArgs e)
        {
            
            form2.ShowDialog();
            try
            {
                string sql = "SELECT idTicket FROM";
                sql += " Ticket WHERE";
                sql += " nome_da_linha = Praiamar";
                DataSet resultado = _banco.Buscar(sql);

                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
