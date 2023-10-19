using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Aluguel
    {
        public int NumeroQuarto { get; set; }
        public Estudante Estudante;

        public Aluguel(int numeroQuarto, Estudante estudante)
        {
            this.NumeroQuarto = numeroQuarto;
            this.Estudante = estudante;
        }
    }
}
