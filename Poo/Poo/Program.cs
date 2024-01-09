// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Poo
{

    public class Program
    {
        public static void Main(string[] args)
        {

            Lists l = new Lists();

            l.AdionarElemento(["Artur", "Mari"]);

            l.Localizar();

            /*Params calc = new Params();
            int num = 10;
            calc.Triple(ref num); // o valor num será agora uma referência.

            Console.WriteLine(num);
            Console.WriteLine(calc.SumWithParams(1, 2, 3));

            int n = int.Parse(Console.ReadLine()!);
            Arrays a = new Arrays();

            Quando for uma array de um objeto, instanciar primeiro o Array e depois instanciar o objeto para cada indíce.
            Produto[] produto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                produto[i] = new Produto { Nome = "Tv 4k", Preco = 4999.99, Quantidade = 1000 };
            }

            
            foreach(Produto p in produto)
            {
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Preco);
                Console.WriteLine(p.Quantidade);

            }
            Console.WriteLine(produto.ToString());
           /* Console.Write($"{a.HeightAvg():F2}");


            //Nullable p = new Nullable();

            //p.Teste();

            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();
            //double areaX, areaY;

            //Console.WriteLine("Informe os lados do triangulo X:");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Informe os lados do triangulo Y:");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //areaX = x.CalcularArea();
            //areaY = y.CalcularArea();


            // instanciação, informar os atributos necessários para inicialização.
            /*Construtor construtor = new Construtor("test", 23);

            // sintaxe alternativa para inicializar valores (funciona mesmo sem construtor)
            Construtor construtor2 = new Construtor() { Arg1 = "teste", Arg2 = 23 };

            Produto produto = new Produto();
            int  quantidade = 0;
            Console.WriteLine("Dados do produto: ");
            produto.Nome = Console.ReadLine();
            produto.Preco = double.Parse(Console.ReadLine());
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine("Digite o número de produtos a serem adicionados");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");
            produto.AdicionarProduto(quantidade);

            Console.WriteLine($"Dados do produto atualizados: {produto}");
            */

        }
    }

}