using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcional4
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        
        public bool Status { get; set; }
        public int TipoCurso { get; set; }

        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Valor da matrícula não pode ser menor ou igual a zero.");
                }
                else
                {
                    matricula = value;
                }
            }

            
        }
        public void ExibirDadosAluno ()
        {
            Console.WriteLine("Nome do Aluno: " + Nome);
            
            if (matricula <= 0)
            {
                Console.WriteLine("Matrícula: inválida!");
                Console.WriteLine("Status: " + Status + ". Não matriculado!");
            }
            else
            {
                Status = true;
                Console.WriteLine("Matrícula: " + matricula);
                Console.WriteLine("Status: " + Status + ". Matriculado");
            }
            
            Console.WriteLine("Email: " + Email); 
           
            Console.WriteLine("Curso: " + TipoCurso);
        }
    }
}
