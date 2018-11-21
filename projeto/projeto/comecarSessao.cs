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
    public partial class comecarSessao : Form
    {
        public comecarSessao()
        {
            InitializeComponent();
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection paraConectar = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bdd;SSL Mode=None");
                paraConectar.Open();
                telaInicial escolher = new telaInicial();
                escolher.ShowDialog();

            }
            catch (MySqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void comecarSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
