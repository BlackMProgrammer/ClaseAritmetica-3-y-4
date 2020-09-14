using System;
using System.Runtime.CompilerServices;

namespace ClaseAritmetica_3_y_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique una Operacion Aritmetica: (La letra)");
            Console.WriteLine("A. Suma");
            Console.WriteLine("B. Resta");
            Console.WriteLine("C. Multiplicar");
            Console.WriteLine("D. Dividir");
            string operacion = Console.ReadLine().ToLower();

            Console.WriteLine("Indique un Numero: ");
            string numero1val = Console.ReadLine();
            double numero1 = Convert.ToDouble(numero1val);

            Console.WriteLine("Indique un Numero: ");
            string numero2val = Console.ReadLine();
            double numero2 = Convert.ToDouble(numero2val);

            double resultado;
           
            switch (operacion)
            {
                case "a":
                    Aritmetica sumar = new Aritmetica(numero1, numero2);
                    resultado = sumar.Sumar(numero1, numero2);
                    Console.Write("La suma de los numeros es {0}", resultado);
                    break;

                case "b":
                    Aritmetica restar = new Aritmetica(numero1, numero2);
                    resultado = restar.Restar(numero1, numero2);
                    Console.WriteLine("La resta de los numeros es {0}",resultado);
                    break;

                case "c":
                    Aritmetica multiplicar = new Aritmetica(numero1, numero2);
                    resultado = multiplicar.Multiplicar(numero1, numero2);
                    Console.WriteLine("La multiplicacion de los numeros es {0}", resultado);
                    break;

                case "d":
                    Aritmetica dividir = new Aritmetica(numero1, numero2);
                    resultado = dividir.Dividir(numero1, numero2);
                    Console.WriteLine("La Division de los numeros es {0}", resultado);
                    break;

                default:
                    Console.WriteLine("Digite una Operacion Valida");
                    break;
            }
        }
    }
}
