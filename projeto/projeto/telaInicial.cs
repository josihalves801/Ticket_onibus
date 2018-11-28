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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Praiamar_Click(object sender, EventArgs e)
        {
            PagarPraiamar praiamar = new PagarPraiamar();
            praiamar.ShowDialog();
        }

        private void Litoranea_Click(object sender, EventArgs e)
        {
            escolherLinha escolher = new escolherLinha();
            escolher.ShowDialog();
        }
    }
}
