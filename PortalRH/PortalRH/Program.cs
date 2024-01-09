using PortalRH.Entities;
using PortalRH.Entities.Enums;
using System.Globalization;

namespace PortalRH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string departmentName;
            string workerName;
            double baseSalary;
            int contractNumber;
            WorkerLevel level;

            Console.WriteLine("Department's name: ");
            departmentName = Console.ReadLine() ?? "Design";

            Console.WriteLine("Enter worker Data: ");
            

            Console.WriteLine("Name:");
            workerName = Console.ReadLine() ?? "John Doe";

            Console.WriteLine("Level: Junior/MidLevel/Seior");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine() ?? "Junior");

            Console.WriteLine("Base Salary: ");
            baseSalary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departmentName);

            Worker worker = new Worker(workerName, level, baseSalary, department);

            Console.WriteLine("How many contracts to this worker? ");
            contractNumber = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= contractNumber; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");

                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Duration (hours): ");
                int hours = Convert.ToInt32(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hours);

                worker.Contracts.Add(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income: MM/YYYY");
            string[] monthAndYear = Console.ReadLine()!.Split('/');

            int month = Convert.ToInt32(monthAndYear[0]);
            int year = Convert.ToInt32(monthAndYear[1]);


            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {month}/{year}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
            



        }
    }
}
