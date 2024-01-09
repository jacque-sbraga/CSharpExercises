using AulasIntermediarias.Entities;
using AulasIntermediarias.Entities.Enums;

namespace AulasIntermediarias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1230, Moment = DateTime.Now, Status = OrderStatus.Processing };

            // converter Enum para string
            string text = OrderStatus.Processing.ToString();

            // Converter uma string para enum
            OrderStatus orderStatus = Enum.Parse<OrderStatus>("Delivered"); // o valor precisa existir no enum

            Console.WriteLine(order);
            Console.WriteLine(text);
            Console.WriteLine(orderStatus);
        }
    }
}
