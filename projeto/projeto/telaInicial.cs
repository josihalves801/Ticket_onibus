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
    public partial class telaInicial : Form
    {
        public telaInicial()
        {
            InitializeComponent();
        }

        private void litoranea_Click(object sender, EventArgs e)
        {
            escolherLinha form3 = new escolherLinha();
            form3.ShowDialog();

        }

        private void praiamar_Click(object sender, EventArgs e)
        {
            PagarPraiamar form2 = new PagarPraiamar();
            form2.ShowDialog();
        }
    }
}