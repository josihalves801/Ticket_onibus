using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto
{
    public partial class PagarLagoinha : Form
    {
        private decimal dinheiro = 0;

        private readonly MySqlConnection paraConectar;

        public PagarLagoinha()
        {
            InitializeComponent();
            try
            {
                paraConectar = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bdd;SSL Mode=None");
                paraConectar.Open();

            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

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
            if (result2 == "Venda efetuada com sucesso!")
            {
                MySqlCommand comando = new MySqlCommand("insert into Ticket (idTicket, nome_da_linha, data, valor_ticket, data_uso) values(null, ?, ?, ?, ?)", paraConectar);
                comando.Parameters.AddWithValue("@nome_da_linha", "Ubatuba - Lagoinha");
                comando.Parameters.AddWithValue("@data", DateTime.Now.ToString("dd/MM/yyyy"));
                comando.Parameters.AddWithValue("valor_ticket", "4,95");

            }
            else
            {
                MessageBox.Show(result2);
            }
        }

        private void PagarLagoinha_Load(object sender, EventArgs e)
        {

        }

        private void PagarLagoinha_Load(object sender, EventArgs e)
        {

        }
    }
}
