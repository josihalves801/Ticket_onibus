using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    public class Maquina1
    {
        private decimal dim;
        private decimal Troco;
        private decimal value;

        public decimal Dim { get => dim; set => dim = value; }
        public decimal Troco1 { get => Troco; set => Troco = value; }


        public string RealizaVenda(decimal Dim)
        {
            if  (Dim > Convert.ToDecimal(3.80))
            {
                Troco = dim - Convert.ToDecimal(3.80);
                return "troco:" + Troco ;
            }
            if (Dim < Convert.ToDecimal(3.80))
            {
                Troco = Convert.ToDecimal(3.80) - Dim;
                return "Insira" + Troco;
            }
            if (Dim == Convert.ToDecimal(3.80))
            {
                return "venda efetuada com sucesso" ;
            }
        }

    }
}
