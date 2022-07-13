
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
    public class Cliente
    {
        public string nome;
        public Endereco endereco;
        public string email;
        public string telefone;
        public string cpf;

        public void ExibirDadosCliente ()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine(endereco.rua);
            Console.WriteLine("Número: " + endereco.numero);
            Console.WriteLine("Bairro: " + endereco.bairro);
            Console.WriteLine("Cidade: " + endereco.cidade);
            Console.WriteLine("CEP: " + endereco.cep);
        }
    }
}
