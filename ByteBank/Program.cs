using bytebank;
using bytebank.Titular;

Console.WriteLine("Bem vindo ao seu banco, ByteBank!");
Console.WriteLine();

//ContaCorrente conta1 = new ContaCorrente();
//conta1.titular = "André Silva";
//conta1.conta = "10123-x";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "André Silva";
//conta2.conta = "10123-x";
//conta2.numero_agencia = 23;
//conta2.nome_agencia = "Agência Central";
//conta2.saldo = 100;

//Cliente cliente1 = new Cliente();
//cliente1.nome = "André Silva";
//cliente1.cpf = "000.000.000-00";
//cliente1.profissao = "Programador C#";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = cliente1;
//conta3.conta = "123456-y";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agência Central";

//ContaCorrente conta4 = new ContaCorrente();
//conta4.conta = "654321-k";
//conta4.numero_agencia = 96;
//conta4.nome_agencia = "Agência Central";

//if (conta4.titular == null)
//{
//    Console.WriteLine("O campo titular está nulo");
//}

Cliente sarah = new Cliente();
sarah.Nome = "Sara Silva";


ContaCorrente conta5 = new ContaCorrente(235,"123456-x"); //fornecendo nº da agencia e nº da conta
conta5.Saldo = 100;
conta5.Titular = sarah;
Console.WriteLine("Titular: " + conta5.Titular.Nome);
Console.WriteLine("saldo: " + conta5.Saldo);
Console.WriteLine("Nº agência: " + conta5.Numero_agencia);
Console.WriteLine("Nº conta: " + conta5.Conta);

Console.ReadKey();