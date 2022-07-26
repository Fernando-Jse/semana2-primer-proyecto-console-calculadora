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
            // Declare variables and then initialize to zero.
            int num1 = 0; int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Calculadora en Consola de C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number.
            Console.WriteLine("Digite un número, y presione ENTER para continuar");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Digite otro número, Y presione ENTER para continuar");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Elija una opción de la lista que se muestra a contiuación:");
            Console.WriteLine("\ta - Sumar");
            Console.WriteLine("\ts - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Tú Opción? ");

            // Use a switch statement to do the math.
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
            // Wait for the user to respond before closing.
            Console.Write("Presione cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
