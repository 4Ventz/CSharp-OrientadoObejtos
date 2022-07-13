using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastfood;

namespace fastfood
{
    public class Produto
    {
        public string codigoProduto;
        public string nomeProduto;
        public string descricao;
        public double valorUnd;
        public int quantidade;

        public void ExibirDadosProduto()
        {
            Console.WriteLine(nomeProduto);
            Console.WriteLine(descricao);
            Console.WriteLine("Preço unitário: R$ " + valorUnd);
            Console.WriteLine(quantidade);
        }
    }
}
