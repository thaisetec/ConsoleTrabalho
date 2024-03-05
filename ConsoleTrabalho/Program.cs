using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Qual é o salário bruto?");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do seu vale alimentação");
            double val = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos filhos vc tem?");
            int fil = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor a empresa disponibiliza por filho?");
            int valorfil = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas extras vc fez?");
           int qnthora = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor por hora?");
            double porhora = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor do inss");
         double inss = double.Parse (Console.ReadLine());
            Console.WriteLine("digite o valor do irf");
            double irf =double.Parse(Console.ReadLine());
            double liquido = sal = val + (fil * valorfil) +
               (qnthora * porhora) - inss - irf;
            Console.WriteLine("salario liquido: " + liquido.ToString());
            Console.ReadKey();
        }
    }
}
