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
    public partial class Pagar_Lagoinha : Form
    {
        decimal dinheiro = 0;
        private readonly MySqlConnection paraConectar;

        public Pagar_Lagoinha()
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

        private void Pagar_Lagoinha_Load(object sender, EventArgs e)
        {

        }

        private void continuar_Click(object sender, EventArgs e)
        {

            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dimLago.Value;
            string result1 = maquina1.RealizaVenda(dinheiro);


            if (result1 == "Venda efetuada com sucesso!")
            {
                MySqlCommand comando = new MySqlCommand("insert into Ticket (idTicket, nome_da_linha, data, valor_ticket, data_uso) values(null, ?, ?, ?, ?)", paraConectar);
                comando.Parameters.AddWithValue("@nome_da_linha", "Praiamar");
                comando.Parameters.AddWithValue("@data", DateTime.Now.ToString("dd/MM/yyyy"));
                comando.Parameters.AddWithValue("valor_ticket", "3,80");
                Vendido vendido = new Vendido();
                vendido.ShowDialog();
            }
            else
            {
                MessageBox.Show(result1);
            }

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
