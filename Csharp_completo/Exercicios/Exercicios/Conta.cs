using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    class Conta
    {
        public double Saldo{ get; private set; }
        public string NumeroConta { get; private set; }
        public string Titular { get; set; }

        public Conta(string NumeroConta, string Titular)
        {
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
        }

        public Conta(string NumeroConta, string Titular, double Saldo) : this (NumeroConta, Titular)
        {
            this.Saldo = Saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta "
            + NumeroConta
            + "\nTitular: "
            + Titular
            + "\nSaldo: "
            + Saldo.ToString("F2");
        }

    }
}
