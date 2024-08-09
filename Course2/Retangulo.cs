using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double somaPotencia = Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00);
            double result = Math.Sqrt(somaPotencia);
            return result;
        }
    }
}
