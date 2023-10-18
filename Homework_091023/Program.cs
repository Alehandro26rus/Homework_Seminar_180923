using System;

public class Answer {
    public static void PrintArray(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j].ToString() + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int value = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }

        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        Console.Write("The averages in columns are:\n");
        foreach (var avg in list)
        {
            Console.Write($"{avg:F2}\t");
        }
        Console.WriteLine();
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[] averages = new double[cols];

        for (int j = 0; j < cols; j++)
        {
            double columnSum = 0;
            for (int i = 0; i < rows; i++)
            {
                columnSum += matrix[i, j];
            }
            averages[j] = columnSum / rows;
        }

        return averages;
    }

    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}


