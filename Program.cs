using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2_primer_proyecto_console_calculadora
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0; int num2 = 0;

            
            Console.WriteLine("Calculadora en Consola de C#\r");
            Console.WriteLine("------------------------\n");

            
            Console.WriteLine("Digite un número, y presione ENTER para continuar");
            num1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Digite otro número, Y presione ENTER para continuar");
            num2 = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Elija una opción de la lista que se muestra a contiuación:");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Tú Opción? ");

            
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu Resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Tu Resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu Resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu Resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
