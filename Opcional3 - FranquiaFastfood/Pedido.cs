using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastfood;

namespace fastfood
{
    public class Pedido
    {
        public string numeroPedido;
        public Cliente titular;
        public double valorTotal;
        public string formaPagamento;

        public void ExibirDadosPedido()
        {
            Console.WriteLine("Dados do Pedido:");
            Console.WriteLine("Pedido Nº: " + numeroPedido);
            Console.WriteLine("Cliente: " + titular.nome);
            Console.WriteLine("Valor Total: R$ " + valorTotal);
            Console.WriteLine("Forma de pagamento: " + formaPagamento);

        }
    }
}
