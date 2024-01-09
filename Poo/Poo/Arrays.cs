using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Arrays
    {

        public double HeightAvg() {
            int n = int.Parse(Console.ReadLine()!);
            int i = 0;
            double[] arrHeight = new double[n];
            double total = 0.0;

            while (i < n)
            {
                arrHeight[i] = double.Parse(Console.ReadLine()!);
                total += arrHeight[i];
                i++;
            }

            return total / arrHeight.Length;
        }
    }
}
