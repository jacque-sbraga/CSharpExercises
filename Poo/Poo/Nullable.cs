using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Nullable
    {
        //double x = null; // isso não é permitido
        Nullable<double> y = null; 

        //Nullable tem métodos:

        double? x = null;
        
        // Operador de coalescência nula: se um valor da esquerda for nulo ele usa o valor da direita
        double? a = null;
        double? b = 10;


        

       
        public void Teste()
        {
            Console.WriteLine(x.GetValueOrDefault()); // pegar o valor, caso não tenha pega o default.
            Console.WriteLine(x.HasValue); // será false pois não tem valor
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(y.HasValue); // será true pois tem valor atribuído.
            //Console.WriteLine(x.Value); em valores null retorna erro.

            double c = b ?? 5.00;

            Console.WriteLine(c);


        }
    }
}
