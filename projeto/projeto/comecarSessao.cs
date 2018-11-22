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
            telaInicial escolher = new telaInicial();
             escolher.ShowDialog();

            

        }

        private void comecarSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
