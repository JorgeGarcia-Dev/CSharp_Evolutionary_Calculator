using System;

namespace calculadoraEvolutiva
{
    class Program
    {
        static void Sumar()
        {
            System.Console.WriteLine("Ingresa el primer número para tu operación:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Ingresa el segundo número para tu operación:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;
            System.Console.WriteLine($"El resultado de la suma es: {resultado}");
        }

        static void Restar()
        {
            System.Console.WriteLine("Ingresa el primer número para tu operación:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Ingresa el segundo número para tu operación:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 - num2;
            System.Console.WriteLine($"El resultado de la resta es: {resultado}");
        }

        static void Multiplicar()
        {
            System.Console.WriteLine("Ingresa el primer número para tu operación:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Ingresa el segundo número para tu operación:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 * num2;
            System.Console.WriteLine($"El resultado de la multilicación es: {resultado}");
        }

        static void Dividir()
        {
            System.Console.WriteLine("Ingresa el primer número para tu operación:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Ingresa el segundo número para tu operación:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 / num2;
            System.Console.WriteLine($"El resultado de la división es: {resultado}");
        }

        static void Calculadora()
        {
            bool fin = false;
            int opcion = 0;

            while(!fin)
            {
                System.Console.WriteLine("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Sumar();
                        break;
                    case 2:
                        Restar();
                        break;
                    case 3:
                        Multiplicar();
                        break;
                    case 4:
                        Dividir();
                        break;
                    case 5:
                        fin = true;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("********** Calculadora Evolutiva **********");
            System.Console.WriteLine("Menú:");
            System.Console.WriteLine("1. Sumar");
            System.Console.WriteLine("2. Restar");
            System.Console.WriteLine("3. Multiplicar");
            System.Console.WriteLine("4. Dividir");
            System.Console.WriteLine("5. Salir");
            Calculadora();
            System.Console.WriteLine("Programa Finalizado.");
            Console.ReadLine();
        }
    }
}
