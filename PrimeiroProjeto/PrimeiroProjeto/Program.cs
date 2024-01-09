using System; // referência para o namespace System
using System.Globalization;

namespace PrimeiroProjeto
{
    // Todo código c# precisa estar dentro de uma classe. O nome será o mesmo do arquivo.
    internal class Program
    {
        // O membro da classe
        static void Main(string[] args)
        {
            sbyte numeroByte = 127; // de -128 até 127
            SByte numeroDotNet = 127;

            //Tipos para números inteiros:

            // O que é overflow? Calculo que extrapola o limite da variável.
            byte n1 = 254; // vai de 0 até 255 e não tem sinal.
            n1++;
            n1++;

            int n2 = 1000;
            int n3 = 2147483647; // esse é o valor máximo de int.

            long n4 = 2147483648L; // para números do tipo long, recomenda-se usar o L no  final.

            bool flag = false; // guarda valores true/false
            char n5 = '\u0041'; // armazena apenas um caractere ou o código unicode
            float n6 = 4.5f; // para usar um float precisa colocar a letra f no final;
            double n7 = 4.55454;
            string n8 = "Maria Green";

            double min = double.MinValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(min);
            Console.WriteLine(n7.ToString("F2")); // converte um numero para string (F2 -> serão considerados 2 casas decimais)
            Console.WriteLine(n7.ToString("F2", CultureInfo.InvariantCulture));


            //Placeholders, concatenação e interpolação

            int idade = 32;
            string nome = "Maria";
            double saldo = 5545.54484;

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e R${2:F2} na conta", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo R$ {saldo:F2}");

            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo R$ " + saldo.ToString("F2", CultureInfo.InvariantCulture));


            // Conversão implpicita e casting

            // Conversão implicíta -> conteúdo de um tipo pode ser atribuído para variável de outro tipo.
            //Casting -> conversão explicíta entre tipos compatíveis
            float x = 4.5f;
            double y = x; // é um conversão implícita

            double a = 10.55;
            float b = (float) a; // será necessário fazer o casting

            int c = (int) b; // converter double/float para int, os valores após a vírgula serão truncados.


            Console.WriteLine(c);

            string result = Teste.SayName("Jacqueline");

            Console.WriteLine(result);
            // Entrada de dados
            string frase = Console.ReadLine();
            string cor1 = Console.ReadLine();
            string cor2 = Console.ReadLine();
            string cor3 = Console.ReadLine();
            string[] linha = Console.ReadLine().Split(" ");
            int age = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double xx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(frase);
            Console.WriteLine(cor1);
            Console.WriteLine(cor2);
            Console.WriteLine(cor3);
            Console.WriteLine(linha[0], linha[1], linha[2]);


        }
    }

    static class Teste { 
        public static string SayName(string name)
        {
            return $"Hello {name}";
        }
    }

}
