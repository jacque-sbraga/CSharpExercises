using System;


namespace Becrowd
{
    public class Circulo
    {
        public double raio { get; set; }

        public double CalcularArea(double raio)
        {
            double area = Math.PI * raio * raio;

            return area;
        }
    }
}
