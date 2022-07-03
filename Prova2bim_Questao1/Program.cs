using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2bim_Questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trab, p1, p2, media;
            string aluno;

            Console.Write("Escreva o nome do Aluno: ");
            aluno = Convert.ToString(Console.ReadLine());
            Console.Write("Digite a nota do trabalho: ");
            trab = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da prova 1: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a nota da prova 2: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            if (trab < 0 || p1 < 0 || p2 < 0) {
                Console.Write("Só são aceitas notas maiores que 0!");
            } else {
                media = (trab + p1 + p2) / 3;

                if (media >= 8.5) {
                    Console.Write("O aluno " + aluno + " obteve média " + media + ". Parabéns!");
                } else if (media >= 7 && media <= 8.4) {
                    Console.Write("O aluno " + aluno + " obteve média " + media + ". Muito Bem!");
                } else if (media >= 6 && media <= 6.9) {    
                    Console.Write("O aluno " + aluno + " obteve média " + media + ". Na média, Cuidado!");
                } else if (media >= 0.1 && media <= 5.9) {
                    Console.Write("O aluno " + aluno + " obteve média " + media + ". Aluno está de recuperação!");
                } else if (media >= 0 && media < 0.1) {
                    Console.Write("O aluno " + aluno + " obteve média " + media + ". Reprovado.");
                }
            }
            Console.ReadKey();
        }
    }
}
