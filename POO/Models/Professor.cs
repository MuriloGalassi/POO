using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal class Professor : Pessoa
    {
        public Professor()
        {
        }

        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos, sou prefessr e meu salario é:{Salario}");
        }
    }
}
