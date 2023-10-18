//Задание 1. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
// _________________________________________________________________________


using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    {
        // Проверяем, можно ли умножить матрицы
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            Console.WriteLine("Матрицы нельзя умножить, так как количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return;
        }


        // Вычисляем произведение матриц
        int[,] product = MatrixMultiplication(matrixA, matrixB);

        // Выводим результат
        PrintMatrix(product);
    }


    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        // Создаем матрицу произведения
        int[,] product = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

        // Перебираем строки первой матрицы
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            // Перебираем столбцы второй матрицы
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                // Вычисляем элемент произведения
                int sum = 0;
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }

                // Задаем элемент произведения
                product[i, j] = sum;
            }
        }

        // Возвращаем матрицу произведения
        return product;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        // Выводим матрицу
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {5, 2},
                {8, 1}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8}
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}
