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
        private decimal falta;

        public decimal Dim { get => dim; set => dim = value; }
        public decimal Troco1 { get => Troco; set => Troco = value; }
        public decimal Falta { get => falta; set => falta = value; }

        public string RealizaVenda(decimal Dim)
        {
            if (Dim > Convert.ToDecimal(3.80))//dinheiro maior
            {
                Troco = Dim - Convert.ToDecimal(3.80);
                return "troco:" +  Troco;
            }
            else if (Dim < Convert.ToDecimal(3.80))//dinheiro menor
            {
                Falta = Convert.ToDecimal(3.80) - Dim;
                return "Insira" +  Falta;
                
            }
            else if (Dim == Convert.ToDecimal(3.80)) //dinheiro certo
            {
                return "Venda efetuada com sucesso!";
            }
            else return "Não foi possível efetuar a venda.";
            
        }

    }
}
