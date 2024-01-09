using System.Globalization;

using Becrowd;

namespace Becrowd {

    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double area;

            Circulo circulo = new Circulo();

            circulo.raio = raio;

            area = circulo.CalcularArea(circulo.raio);

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }

    
}
