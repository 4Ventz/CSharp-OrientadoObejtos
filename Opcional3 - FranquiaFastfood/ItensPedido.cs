using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastfood;

namespace fastfood
{
    public class ItensPedido
    {
        public Produto escolha1;
        public Produto escolha2;
        public Produto escolha3;

        public void ExibirDadosItensPedido()
        {
            Console.WriteLine("Itens Pedidos:");
            Console.WriteLine("1º Produto:");
            Console.WriteLine("Código do produto: " + escolha1.codigoProduto);
            Console.WriteLine("Nome do Produto: " + escolha1.nomeProduto);
            Console.WriteLine("Valor und.: R$ " + escolha1.valorUnd);
            Console.WriteLine("Quantidade escolhida: " + escolha1.quantidade);
            Console.WriteLine();

            Console.WriteLine("2º Produto:");
            Console.WriteLine("Código do produto: " + escolha2.codigoProduto);
            Console.WriteLine("Nome do Produto: " + escolha2.nomeProduto);
            Console.WriteLine("Valor und.: R$ " + escolha2.valorUnd);
            Console.WriteLine("Quantidade escolhida: " + escolha2.quantidade);
            Console.WriteLine();

            Console.WriteLine("3º Produto:");
            Console.WriteLine("Código do produto: " + escolha3.codigoProduto);
            Console.WriteLine("Nome do Produto: " + escolha3.nomeProduto);
            Console.WriteLine("Valor und.: R$ " + escolha3.valorUnd);
            Console.WriteLine("Quantidade escolhida: " + escolha3.quantidade);


        }
    }
}
