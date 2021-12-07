using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPoo
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Title = " ### Média Geral dos Alunos ### ";
            Console.Write("Quantos Alunos ? ");
            int nAlunos = int.Parse(Console.ReadLine());


            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno # " + (i + 1) + " Nome..: ");
                string nome = Console.ReadLine();

                Console.Write("Aluno # " + (i + 1) + " Quantidade de Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotaas();

            }
            Console.Clear();

            double MediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Media: " + aluno.media);
                Console.WriteLine();
                MediaGeral += aluno.media;
            }

            double ResultadoFinal = MediaGeral / alunos.Length;

            Console.WriteLine("Média Geral dos Alunos: " + ResultadoFinal);

            Console.ReadKey();
        }
    }

}
