using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Estudante
    {
        public string Nome { get; private set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString() 
        {
            return Nome + ", " + Email;
        }
    }
}
