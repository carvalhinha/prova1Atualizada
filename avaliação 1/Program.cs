using System;
using System.Globalization;
namespace avaliação_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            string[] nome = new string[5]; ;
            double[] nota = new double[5]; ;
            double percAprov = 0, percReprov = 0, media = 0;
            int contAprovados = 0, contReprovados = 0;

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.WriteLine("digite o nome e a nota do aluno:");
                    s = Console.ReadLine().Split(' ');
                    nome[i] = (s[0]);
                    nota[i] = Convert.ToDouble(s[1], CultureInfo.InvariantCulture);

                    while (nota[i] > 10 || nota[i] < 0)
                    {
                        Console.WriteLine("Digite uma nota válida para o aluno!\n");
                        nota[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro \n");
                    i--;
                }
            }
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                if (nota[i] >= 5)
                {
                    contAprovados++;
                    percAprov = (contAprovados * 100) / 5;
                    Console.WriteLine($"O aluno {nome[i]} tirou {nota[i]} e foi aprovado.");

                }
                else
                {
                    contReprovados++;
                    percReprov = (contReprovados * 100) / 5;
                    Console.WriteLine($"O aluno {nome[i]} tirou {nota[i]} e foi reprovado.");
                }
                media += nota[i] / 5;
            }
            Console.WriteLine($"\nMédia da turma: {media.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Tiveram {percAprov} % de Alunos aprovados e Tiveram {percReprov} % de Alunos reprovados.");
        }
    }
}

