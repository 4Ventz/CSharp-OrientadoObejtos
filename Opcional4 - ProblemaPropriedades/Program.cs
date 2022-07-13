/*O encapsulamento é uma prática recomendada. Definimos campos privados usando métodos públicos ou utilizando propriedades. Com base nisso, Pedro criou a seguinte classe:
class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }
    public int TipoCurso { get; set; }
}
Porém, a propriedade Matricula precisa validar a operação de Set, não permitindo a inserção de valores menores ou iguais a zero.
Como Pedro poderia resolver o problema? E você, consegue solucionar esse desafio?*/

using Opcional4;

Console.WriteLine("Opcional4 - Matrícula de Alunos");
Console.WriteLine();

Aluno aluno1 = new Aluno();
aluno1.Nome = "Fulano Silva";
aluno1.Email = "fulanoSilva@teste.com";
aluno1.TipoCurso = 1;
aluno1.Matricula = 10;

aluno1.ExibirDadosAluno();

Console.ReadKey();