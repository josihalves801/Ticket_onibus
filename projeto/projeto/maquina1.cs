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
        private decimal dimLago;
        private decimal dimCentro;
        private decimal dimSeba;

        public decimal Dim { get => dim; set => dim = value; }
        public decimal Troco1 { get => Troco; set => Troco = value; }
        public decimal Falta { get => falta; set => falta = value; }
        public decimal DimLago { get => dimLago; set => dimLago = value; }
        public decimal DimCentro { get => dimCentro; set => dimCentro = value; }
        public decimal DimSeba { get => dimSeba; set => dimSeba = value; }

        public string RealizaVenda(decimal Dim)
        {
            if (Dim > Convert.ToDecimal(3.80))//dinheiro maior
            {
                Troco = Dim - Convert.ToDecimal(3.80);
                return "troco: " +  Troco;
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
            else return "Não foi possível efetuar a venda. ";
            
        }
        public string RealizaVenda2(decimal DimLago)
        {
            if (DimLago > Convert.ToDecimal(4.95))//dinheiro maior
            {
                Troco = DimLago - Convert.ToDecimal(4.95);
                return "troco: " + Troco;
            }
            else if (DimLago < Convert.ToDecimal(4.95))//dinheiro menor
            {
                Falta = Convert.ToDecimal(4.95) - DimLago;
                return "Insira" + Falta;

            }
            else if (DimLago == Convert.ToDecimal(4.95)) //dinheiro certo
            {
                return "Venda efetuada com sucesso! ";
            }
            else return "Não foi possível efetuar a venda. ";
        }
        public string RealizaVenda3(decimal DimCentro)
        {
            if (DimCentro > Convert.ToDecimal(8.90))//dinheiro maior
            {
                Troco = DimCentro - Convert.ToDecimal(8.90);
                return "troco: " + Troco;
            }
            else if (DimCentro < Convert.ToDecimal(8.90))//dinheiro menor
            {
                Falta = Convert.ToDecimal(8.90) - DimCentro;
                return "Insira" + Falta;

            }
            else if (DimCentro == Convert.ToDecimal(8.90)) //dinheiro certo
            {
                return "Venda efetuada com sucesso! ";
            }
            else return "Não foi possível efetuar a venda. ";
        }
        public string RealizaVenda4(decimal DimSaba)
        {
            if (DimSeba > Convert.ToDecimal(5.15))//dinheiro maior
            {
                Troco = DimSeba - Convert.ToDecimal(5.15);
                return "troco: " + Troco;
            }
            else if (DimSeba < Convert.ToDecimal(5.15))//dinheiro menor
            {
                Falta = Convert.ToDecimal(5.15) - DimSeba;
                return "Insira" + Falta;

            }
            else if (DimSeba == Convert.ToDecimal(5.15)) //dinheiro certo
            {
                return "Venda efetuada com sucesso! ";
            }
            else return "Não foi possível efetuar a venda. ";
        }
    }
}
