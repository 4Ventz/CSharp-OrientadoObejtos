using bytebank;
Console.WriteLine("Bem vindo ao seu banco, ByteBank!");
Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "André Silva";
conta2.conta = "10123-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Saldo da Amanda pré-transferência: " + conta1.saldo);
Console.WriteLine("Saldo do André  pré-transferência: " + conta2.saldo);
Console.WriteLine();

bool transferencia = conta1.Transferir(50, conta2);

Console.WriteLine("Trasferência realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo da Amanda pós-transferência: " + conta1.saldo);
Console.WriteLine("Saldo do André  pós-transferência: " + conta2.saldo);

Console.ReadKey();