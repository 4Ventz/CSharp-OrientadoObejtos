//Lorena é proprietária de uma franquia de fast food e quer disponibilizar para seus franqueados um sistema de pedidos online.
//O sistema idealizado por ela deverá trabalhar com informações de pedidos de clientes, como valor total do pedido, cliente, endereço de entrega e os itens selecionados (máximo de 3).
//Te desafiamos a criar uma composição de classes que poderá ser usada no desenvolvimento do sistema da Lorena. Vamos ao desafio?

using fastfood;

Console.WriteLine("Bem vindo ao app Fastfood!");
Console.WriteLine();

Endereco endereco1 = new Endereco();
endereco1.rua = "Rua Teste da esquina";
endereco1.numero = "???";
endereco1.bairro = "Testando";
endereco1.cidade = "Tentativas";
endereco1.cep = "xx.xxx.xxx";

Cliente cliente1 = new Cliente();
cliente1.nome = "Fulano Silva";
cliente1.email = "fulano.silva@teste.com";
cliente1.telefone = "(xx) xxxxx-xxxx";
cliente1.cpf = "xxx.xxx.xxx-xx";
cliente1.endereco = endereco1;

Produto produto1 = new Produto();
produto1.codigoProduto = "123456789";
produto1.nomeProduto = "Sopa";
produto1.descricao = "Deliciosa sopa de legumes";
produto1.valorUnd = 20.50;
produto1.quantidade = 1;

Produto produto2 = new Produto();
produto2.codigoProduto = "100000000";
produto2.nomeProduto = "Churrasco";
produto2.descricao = "Mistura de carnes nobres";
produto2.valorUnd = 40.00;
produto2.quantidade = 2;

Produto produto3 = new Produto();
produto3.codigoProduto = "000055589";
produto3.nomeProduto = "Sorvete de creme";
produto3.descricao = "Cremoso sorvete e delicioso sorvete de creme!";
produto3.valorUnd = 5.00;
produto3.quantidade = 1;

ItensPedido itensPedido1 = new ItensPedido();
itensPedido1.escolha1 = produto1;
itensPedido1.escolha2 = produto2;
itensPedido1.escolha3 = produto3;

Pedido pedido1 = new Pedido();
pedido1.numeroPedido = "00001";
pedido1.titular = cliente1;
pedido1.valorTotal = 65.50;
pedido1.formaPagamento = "cartão";


//cliente1.ExibirDadosCliente();
//endereco1.ExibirDadosEndereco();
//Console.WriteLine( );
////produto1.ExibirDadosProduto();
//Console.WriteLine();
//produto2.ExibirDadosProduto();
//Console.WriteLine();
//produto3.ExibirDadosProduto();
pedido1.ExibirDadosPedido();
Console.WriteLine();
itensPedido1.ExibirDadosItensPedido();

Console.ReadKey();












