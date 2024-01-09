using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Construtor
    {
        // operação especial da classe, executa no momento da instanciação do projeto.
        // sobrecarga -> especificar mais de um construtor na mesma classe
        // Tem o mesmo nome da classe
        public string Arg1;
        public int Arg2;

        public Construtor() { } // construtor padrão sem parâmetros de inicialização.

        // : this() -> chama o construtor padrão.
        public Construtor(string arg1, int arg2) : this() {
            Arg1 = arg1;
            Arg2 = arg2;

        }
        

    }
}
