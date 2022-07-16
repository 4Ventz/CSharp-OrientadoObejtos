using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;
        public int Numero_Agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_Agencia { get; set;}
        
        private double saldo;

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }

        public bool Sacar (double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar (double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir (double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public static int TotalDeContasCriadas { get; set; }

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_Agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Nome do titular: " + Titular.Nome);
            Console.WriteLine("Número da conta: " + Conta);
            Console.WriteLine("Nome da agência: " + Nome_Agencia);
            Console.WriteLine("Número da agência: " + Numero_Agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

    
    }
}