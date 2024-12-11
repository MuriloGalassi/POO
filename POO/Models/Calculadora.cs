using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Interfaces;

namespace POO.Models
{
    internal class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subitrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
