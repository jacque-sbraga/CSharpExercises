using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Poo
{
    class Lists
    {
        //List<string> lista = new List<string>();

        // já instancia e atribui valores para a lista
        List<string> lista = new List<string> { "Maria", "Eduardo" };

        public void AdionarElemento(params string[] elemento)
        {
            lista.Add(elemento[0]); // adiciona sempre ao final da lista
            lista.Insert(3, elemento[1]); // adiciona com base em uma posição, (não é possível adicionar valor em uma posíção que não existe)
        }

        public void Tamanho()
        {
            Console.WriteLine(lista.Count);
        }

        public void Localizar()
        {
            string result = lista.Find(texto => texto == "Maria") ?? "Não localizado"; // expressão lambda (parecido com arrow function do js)
            Console.WriteLine(result);
        }

    }
}
