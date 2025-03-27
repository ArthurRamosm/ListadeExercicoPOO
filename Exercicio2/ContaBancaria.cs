using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class ContaBancaria
    {
        public string NumeroConta;
        public string Titular;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
         public void ExibirSaldo()
        {
            Console.WriteLine("Saldo");
        }
    }
}
