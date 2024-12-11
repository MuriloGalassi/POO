using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno()
        {
        }

        public Aluno(string nome) : base(nome)
        {
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}
