using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre as largura e altura do retângulo: ");
            Console.WriteLine("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {retangulo.Area():0.00}");
            Console.WriteLine($"PERIMETRO = {retangulo.Perimetro():0.00}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal():0.00}");





        }
    }
}
