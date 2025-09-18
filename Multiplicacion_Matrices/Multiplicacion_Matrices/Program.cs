using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Ingrese el valor de m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de p: ");
        int p = int.Parse(Console.ReadLine());

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = (i + 1) * j;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = (j + 1) * i;
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        Console.WriteLine("\n*** A ***");
        PrintMatrix(A);

        Console.WriteLine("\n*** B ***");
        PrintMatrix(B);

        Console.WriteLine("\n*** C ***");
        PrintMatrix(C);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}