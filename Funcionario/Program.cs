using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Insira os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
           
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Funcionário: {funcionario.Nome}, ${funcionario.SalarioLiquido()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);

        }
    }
}
