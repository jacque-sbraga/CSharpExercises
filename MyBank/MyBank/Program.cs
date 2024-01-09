// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Principal;

namespace MyBank // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberAccount;
            string name;
            double valor;
            char flagDeposito;
            Cc account;

            Console.Write("Entre com o número da Conta: ");
            numberAccount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            name = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");

            flagDeposito = char.Parse(Console.ReadLine()!);


            if (flagDeposito == 's')
            {
                Console.Write("Informe o valor de depósito: ");
                valor = Convert.ToDouble(Console.ReadLine());
                account = new Cc(name ?? "Joe Doe", numberAccount, valor);
            }
            else
            {
                account = new Cc(name ?? "Joe Doe", numberAccount);
            }

            Console.Write("Dados da conta: ");
            Console.Write(account.ToString());

            Console.Write("Entre com um valor de depósito: ");
            valor = Convert.ToDouble(Console.ReadLine());
            account.Deposito(valor);

            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(account.ToString());

            Console.Write("Entre com um valor de saque: ");
            valor = Convert.ToDouble(Console.ReadLine());
            account.Deposito(valor);

            Console.Write("Dados da conta atualizados: ");
            Console.Write(account.ToString());

        }
    }
}
