using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Params
    {
        public int SumWithArray(int[] values)
        {   
            int total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        // com o params é possível receber uma quantia variável de argumentos para o método
        public int SumWithParams(params int[] values)
        {
            int total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }
            return total;
        }

        // com o ref é possível fazer com a variável passar para o método vire uma referência
        public void Triple(ref int value)
        {
            value = value * 3;
            
        }
    }
}
