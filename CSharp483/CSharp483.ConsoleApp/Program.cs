using CSharp483.ConsoleApp.Tipos.Tipo_Valor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inteiros inteiros = new Inteiros();
            Flutuante flutuante = new Flutuante();
            //inteiros.Executar();
            flutuante.Executar();

            int numero = 10;
            int numeroCopia;
            numeroCopia = numero;

            Console.WriteLine($"Numero1:{numero}");
            Console.WriteLine($"Numero1:{numeroCopia}");
            numero = 15;
            Console.WriteLine($"Numero1:{numero}");
            Console.WriteLine($"Numero1:{numeroCopia}");


            Console.ReadLine();


        }

       
    }
}
