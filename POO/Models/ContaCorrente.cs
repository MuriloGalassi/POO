using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado");
            }
            else
            {
                Console.WriteLine("valor deseja indisponivel");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponivel é: " + saldo);
        }
    }
}
