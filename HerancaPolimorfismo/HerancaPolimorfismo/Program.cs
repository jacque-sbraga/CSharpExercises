using HerancaPolimorfismo.Entities;

namespace HerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(1001, "Alex Green", 0.0);

            // A classe Account é abstrata e não pode ser instanciada.
            Account account = new Account(1001, "Alex Green", 0.0);

            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria Silver", 500.00, 1000);

            // Upcasting
            Account acc1 = businessAccount; // isso é possível pois o BusinessAccount é um Account

            Account acc2 = new BusinessAccount(1003, "Robert Pattison", 0.01, 1000.00);

            Account acc3 = new SavingsAccount(1004, "Anna White", 0.0, 0.01);


            //Downcasting - é um operação insegura, usar somente quando necessário e fazer testes para saber se o objeto é do tipo desejado.
            BusinessAccount acc4 = (BusinessAccount) acc2;

            //BusinessAccount acc5 = (BusinessAccount)acc3; isso gerará um erro de execução. 
            
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            

        }
    }
}
