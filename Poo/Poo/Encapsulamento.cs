using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Encapsulamento
    {
        // implementação manual de encapsulamento
        // todo atributo definido com private
        // implementar get/set conforme as regras de negócio
        // não é muito usual na plataforma C# -> ele tem as properties

        /* Ordem sugerida para implementação de membros: 
            
            * Atributos privados;
            * Propriedades autoimplementadas;
            * Construtores;
            * Propriedades customizadas;
            * Outros métodos da classe.
         
         */

        private int _quantidade;

        // propriedade autoimplementada:
        public string Nome { get; set; }

        // comando: digitar "prop" e pressiinar tab 2x
        public double Preco { get; set; }

        public Encapsulamento(int quantidade, string nome, double preco)
        {
            _quantidade = quantidade;
            Preco = preco;
            Nome = nome;
        }

        public int Quantidade
        {
            // Propriedade customizada
            // properties -> são acessadores e podem ser utilizadas como propriedades
            get { return _quantidade; }
            set {
                if (value >= 0)
                {
                    _quantidade = value;
                }
            }
        }

        /*public int GetQuantidade()
        {
            return _quantidade;
        }

        public int setQuantidade(int quantidade)
        {
            // pode fazer uma lógica no método.
            return _quantidade = quantidade;
        }*/

        // Outros métodos
        public int AdicionarProduto(int produto)
        {
            return _quantidade += produto;
        }
    }
}
