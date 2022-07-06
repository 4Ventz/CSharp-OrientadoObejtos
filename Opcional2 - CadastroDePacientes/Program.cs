//Já sabemos o que são tipo de valor, referência e valor padrão de campos no .NET. Sendo assim, imagine que você precisa cadastrar uma pessoa num sistema médico. Para isso, será necessário criar uma classe Pessoa com os campos referentes ao nome, idade, altura, peso de cada paciente e por fim exibir no Program.cs o valor padrão de cada um dos campos.

using cadastroPacientes;

CadastroPacientes cadastroPacientes1 = new CadastroPacientes();


Console.WriteLine("Nome do Paciente: " + cadastroPacientes1.nome);
Console.WriteLine("Idade: " + cadastroPacientes1.idade + " anos");
Console.WriteLine("Altura: " + cadastroPacientes1.altura + " m");
Console.WriteLine("Peso: " + cadastroPacientes1.peso + " Kg");
Console.WriteLine();

CadastroPacientes cadastroPacientes2 = new CadastroPacientes();
cadastroPacientes2.nome = "Fulano Silva";
cadastroPacientes2.idade = 20;
cadastroPacientes2.altura = 1.80;
cadastroPacientes2.peso = 75;

Console.WriteLine("Nome do Paciente: " + cadastroPacientes2.nome);
Console.WriteLine("Idade: " + cadastroPacientes2.idade + " anos");
Console.WriteLine("Altura: " + cadastroPacientes2.altura + " m");
Console.WriteLine("Peso: " + cadastroPacientes2.peso + " Kg");
Console.WriteLine();