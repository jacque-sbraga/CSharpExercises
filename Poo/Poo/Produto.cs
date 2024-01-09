using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }


        /*public Produto(string nome, double preco, int quantidade){

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }*/
        public double TotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome} ${Preco} {Quantidade} {TotalEstoque()}";
        }
    }
}
