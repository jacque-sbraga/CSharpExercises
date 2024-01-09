using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Cc
    {
        public string Name { get; set; }
        public double Saldo { get; private set; }
        public int AccountNumber { get; private set; }


        public Cc(string name, int account)
        {
            Name = name;
            AccountNumber = account;
        }

        public Cc(string name, int account, double depositoInicial) : this(name, account) {
            Deposito(depositoInicial);
        }

        override
        public string ToString()
        { string info = $"Conta: {AccountNumber}, Titular: {Name}, Saldo: $ {Saldo:F2}";
            return info;
        }

        public double Saque(double value)
        {
            return Saldo -= value + 5.00;
        }

        public double Deposito(double value)
        {
            return Saldo += value;
        }
        
    }
}
