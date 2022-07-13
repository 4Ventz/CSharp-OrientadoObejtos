using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fastfood;

namespace fastfood
{
    public class Endereco
    {
        public string rua;
        public string numero;
        public string bairro;
        public string cidade;
        public string cep;

        public void ExibirDadosEndereco()
        {
            Console.WriteLine("Nome da Rua " + rua);
            Console.WriteLine("Número " + numero);
            Console.WriteLine("Bairro " + bairro);
            Console.WriteLine("Cidade " + cidade);
            Console.WriteLine("CEP: " + cep);
        }
    }
}
