using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Conta
    {

        public int NumeroConta;
        private double Saldo;

        public Conta(int NumeroConta)
        {
           
        }

        public double GetSaldo()
        {
            return (this.Saldo);
        }

        public double Saque(double valor)
        {
            if (GetSaldo() >= valor)
            {
                this.Saldo = GetSaldo() - valor;
            }
            return (GetSaldo());
        }

        public double Deposito(double valor)
        {
            this.Saldo = GetSaldo() + valor;
            return (GetSaldo());
        }
    }
}

