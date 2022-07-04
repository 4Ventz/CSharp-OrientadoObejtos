using bytebank;
Console.WriteLine("Bem vindo ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente(); //Criação de um novo objeto da classe ContaCorrente. É através do objeto criado que utilizaremos a classe.
conta1.titular = "André Silva"; //Através do operador "." acessamos as propriedades da classe
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia central";
conta1.saldo = 100.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Amanda Silva";
conta2.conta = 

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número da agência: " + conta1.numero_agencia);
Console.WriteLine("Nome da agência: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();