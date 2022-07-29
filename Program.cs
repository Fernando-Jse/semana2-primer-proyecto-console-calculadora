using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana2_primer_proyecto_console_calculadora
{
    class calculadora
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                
                Console.Write("Digite un número, y presione ENTER: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta entrada no es valida. Por favor ingrese un valor entero: ");
                    numInput1 = Console.ReadLine();
                }

                
                Console.Write("Escriba otro número, Y luego presione ENTER: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta entrada no es valida. Por favor ingrese un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                
                Console.WriteLine("Elija un operador de la siguiente lista:");
                Console.WriteLine("\ta - Suma");
                Console.WriteLine("\ts - Resta");
                Console.WriteLine("\tm - Multiplicación");
                Console.WriteLine("\td - Divición");
                Console.Write("Tú opción? ");

                string op = Console.ReadLine();

                try
                {
                    result = calculadora.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Está operación dara como resultado un error matemático.\n");
                    }
                    else Console.WriteLine("Tú resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! Ocurrió una excepción tratando de hacer los cálculos.\n - Detalles: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                
                Console.Write("Presione 'n' y Enter para cerrar la app, o presione cualquier otra tecla y Enter para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}
