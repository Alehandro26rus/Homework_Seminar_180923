// **Задача 46:** Задайте двумерный массив размером m×n, заполненный 
// случайными целыми числами.

// m = 3, n = 4.

// 1 4 8 19

// 5 -2 33 -2

// 77 3 8 1
// _____________________________________________________________________

// int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue) //строки, столбцы, значения
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; i < column; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; i < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Inputnumber of columns: ");
// int column = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(System.Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, column, max, min);
// Print2DArray(myArray);

// _______________________________________________________________________

// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

// ___________________________________________________________________________

// using System;

// class Program
// {
    // static int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
    // {
    //     int[,] array = new int[row, column];
    //     Random random = new Random();

    //     for (int i = 0; i < row; i++)
    //     {
    //         for (int j = 0; j < column; j++) // Исправлено условие
    //         {
    //             array[i, j] = random.Next(minValue, maxValue + 1);
    //         }
    //     }

    //     return array;
    // }

    // static void Print2DArray(int[,] array)
    // {
    //     for (int i = 0; i < array.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < array.GetLength(1); j++) // Исправлено условие
    //         {
    //             Console.Write(array[i, j] + " ");
    //         }
    //         Console.WriteLine();
    //     }
    // }

//     static int SumOfMainDiagonal(int[,] array)
//     {
//         int sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++) // Исправлено условие
//             {
//                 if (i == j) sum += array[i, j];
//             }
//         }
//         return sum;
//     }

//     static void Main(string[] args)
//     {
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max); // Поменял местами min и max
// Print2DArray(myArray);
// Console.WriteLine("Sum of the main diagonal: " + SumOfMainDiagonal(myArray));
//     }
// }
// ____________________________________________________________________

// **Задача 48:** Задайте двумерный массив размера m на n, каждый 
// элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный 
// массив на экран.

// m = 3, n = 4.

// 0 1 2 3

// 1 2 3 4

// 2 3 4 5
// ___________________________________________________________________

int[,] CreateArray(int row, int column)
{
    int [,] array = new int[row, column];
    for (int i= 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns);
Print2DArray(myArray);


// _____________________________________________________________________
// **Задача 49:** Задайте двумерный массив. Найдите элементы, у 
// которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Новый массив будет выглядеть вот так:

// 1 4 7 2

// 5 **81** 2 **9**

// 8 4 2 4
// ___________________________________________________________________
public static void Main(string[] args)
{
    Console.Write("Input row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] myArray = Create2DRandomArray(row, columns, min, max);
    Console.WriteLine("Start 2d array: ");
    Print2DArray(myArray);
    Refill2DArray(myArray);
    Console.WriteLine("New 2d array: ");
    Print2DArray(myArray);
}
public static int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
public static void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
public static void Refill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
}
