using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Ingrese el tamaño del rombo: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Ingrese un entero positivo.");
            return;
        }

        if (n % 2 == 0)
        {
            Console.WriteLine("Por favor ingrese un número impar.");
            return;
        }

        int mid = n / 2;

        for (int i = 0; i <= mid; i++)
        {
            Console.Write(new string(' ', mid - i));

            if (i == 0)
            {
                Console.WriteLine("#");
            }
            else
            {
                Console.Write("#");
                Console.Write(new string(' ', 2 * i - 1));
                Console.WriteLine("#");
            }
        }

        for (int i = mid - 1; i >= 0; i--)
        {
            Console.Write(new string(' ', mid - i));
            if (i == 0)
                Console.WriteLine("#");
            else
            {
                Console.Write("#");
                Console.Write(new string(' ', 2 * i - 1));
                Console.WriteLine("#");
            }
        }
    }
}