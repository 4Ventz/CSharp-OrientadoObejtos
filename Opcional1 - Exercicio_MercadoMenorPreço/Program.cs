/*Contrataram você para desenvolver um sistema de gerenciamento de produtos destinado ao estoque do Supermercado Menor Preço. 
O cliente informou a necessidade de cadastrar informações sobre o nome, fabricante, código de barras, valor unitário, valor de compra e quantidade em estoque de determinado produto.

Este é um exercício opcional e te desafiamos a criar uma classe com base na descrição acima. Lembre-se de extrair o máximo de informações que achar necessárias para compor sua classe.*/

using livros;

Livros livro1 = new Livros();
livro1.nomeLivro = "Livro Teste 1";
livro1.autor = "Fulano Silva";
livro1.Editora = "Editora Teste 1";
livro1.valorUnd = 50.00;
livro1.codidoBarras = 1000;
livro1.qntEstoque = 200;

Console.WriteLine("Nome do livro: " + livro1.nomeLivro);
Console.WriteLine("Autor: " + livro1.autor);
Console.WriteLine("Preço unitário: R$ " + livro1.valorUnd);
Console.WriteLine("Código de barras: " + livro1.codidoBarras);
Console.WriteLine("Quantidade em estoque: " + livro1.qntEstoque);
Console.WriteLine();