using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionaEstoque(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoveEstoque(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEstoque().ToString("F2");
        }
    }
}
