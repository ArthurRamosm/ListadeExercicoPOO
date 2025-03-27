using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Alunos
    {
        public int RA;
        public string NomeAluno;
        public double NotaProva;
        public double NotaTrabalho;
       
        public void Media()
        {
            double media = (NotaProva + NotaTrabalho) / 2;
            Console.WriteLine($"A Media do {NomeAluno} é:{media}");
            
        }

        public void ProvaFinal()
        {
            double Nota = (NotaProva + NotaTrabalho);


            double ProvaFinal = (12 - ((NotaTrabalho + NotaProva) / 2));
            if (Nota <= 7)
            {
                Console.WriteLine($"O aluno {NomeAluno} está na Prova Final");
                Console.WriteLine($"O aluno {NomeAluno} precisa tirar {ProvaFinal} para não ser reprovado. ");

            }
            else if (Nota > 7)
            {
                Console.WriteLine($"O aluno {NomeAluno} está Aprovado");
            }


        }
        public void ImprimirNotaFinal()
        {
            ProvaFinal();
            
        }
        public void ReceberDados() {
            Console.WriteLine("Digite o RA do aluno:");
            RA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do aluno:");
            NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a nota da prova:");
            NotaProva = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do trabalho:");
            NotaTrabalho = double.Parse(Console.ReadLine());
        }

    }
    
}
