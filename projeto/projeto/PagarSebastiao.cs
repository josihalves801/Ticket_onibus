﻿using System;
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
    public partial class PagarSebastiao : Form
    {
        private decimal dinheiro = 0;
       
        public PagarSebastiao()
        {
            InitializeComponent();
        }

        private void voltar4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok4_Click(object sender, EventArgs e)
        {
            Maquina1 maquina1 = new Maquina1();
            dinheiro += (decimal)dimSeba.Value;
            string result4 = maquina1.RealizaVenda4(dinheiro);
            MessageBox.Show(result4);
        }
    }
}
