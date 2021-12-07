using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPoo
{
    class Aluno
    {
        public string Nome { get; private set; }

        private double[] _notas;

        public double media
        {
            get
            {
                return CalcularMédia();
            }
        }

        public Aluno (string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotaas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Prova #" + (i + 1) + ": ");
                _notas[i] += double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMédia()
        {
            Double Total = 0;
            for (int i = 0; i < _notas.Length; i++)
            {
                Total += _notas[i];
            }
            return Total / _notas.Length;
        }

    }
}
