using PrimeraClase2020SegundoCuatrimestreLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase2020SegundoCuatrimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Sumando umeros---");
            Console.Write("Ingrese un numero");
            string input1 = Console.ReadLine();

            Console.Write("Ingrese otro numero numero");
            string input2 = Console.ReadLine();

            Console.Write("La suma es: " + Calculadora.Sumar(input1, input2));
            Console.ReadKey();
        }
    }
}
