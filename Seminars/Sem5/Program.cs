// //Задача 1. Задайте массив из 12 элементов, заполненный случайными числами 
// //из промежутка [-9, 9].
// // Найдите сумму отрицательных и положительных элементов массива.

// //Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
// //чисел равна 29, сумма отрицательных равна -20.

// // ______________________________________________________________________

// // int[] CreateRandomArray(int size, int minValue, int maxValue)
// // {
// //     int[] array = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         array[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return array;
// // }

// // void PrintArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         System.Console.Write(array[i] + " ");
// //     }
// //     System.Console.WriteLine();
// // }

// // void FindMinMaxSum(int[] array)
// // {
// //     int positiveSum = 0;
// //     int negativeSum = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if(array[i] > 0)
// //         {
// //             positiveSum += array[i];
// //         }
// //         else
// //         {
// //             negativeSum += array[i];
// //         }
// //     }
// //     System.Console.WriteLine($"Sum of positive elements array -> {positiveSum} \nSum of negative elements array -> {negativeSum}");
// // }

// // System.Console.WriteLine("Input array size: ");
// // int size = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input minimal value: ");
// // int min = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input maximal value: ");
// // int max = Convert.ToInt32(System.Console.ReadLine());

// // int[] myArray = CreateRandomArray(size, min, max);// int[] myArray = CreateUserArray (int size)
// // PrintArray(myArray);
// // FindMinMaxSum(myArray);

// // _____________________________________________________________________
// //Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите 
// // количество элементов массива, 
// //значения которых лежат в отрезке [10,99].

// // int[] CreateRandomArray(int size, int minValue, int maxValue)
// // {
// //     int[] array = new int[size];
// //     for (int i = 0; i < size; i++)
// //     {
// //         array[i] = new Random().Next(minValue, maxValue + 1);
// //     }
// //     return array;
// // }

// // void PrintArray(int[] array)
// // {
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         System.Console.Write(array[i] + " ");
// //     }
// //     System.Console.WriteLine();
// // }


// // int QuantityIntTheSegment(int max, int min, int[] array)
// // {
// //     int count = 0;
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (array[i] <= max && array[i] >= min)
// //         {
// //             count++;
// //         }
// //     }
// //     return count;
// // }

// // System.Console.WriteLine("Input array size: ");
// // int size = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input minimal value: ");
// // int minValue = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input maximal value: ");
// // int maxValue = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input lower border value: ");
// // int min = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input upper border value: ");
// // int max = Convert.ToInt32(System.Console.ReadLine());

// // int[] myArray = CreateRandomArray(size, minValue, maxValue);// int[] myArray = CreateUserArray (int size)
// // PrintArray(myArray);
// // System.Console.WriteLine(QuantityIntTheSegment(max, min, myArray));



// // ____________________________________________________________________________
// //Задача 3.Задайте массив. Напишите программу, которая определяет, 
// // присутствует ли заданное число в массиве.
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// bool Prisutstvie (int num, int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) 
//         return true;
//     }
//     return false;
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// // int[] CreateUserArray (int size)
// // {
// //     int[] array = new int[size];
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         System.Console.Write("Input element array: ");
// //         array[i] = Convert.ToInt32(Console.ReadLine());
// //     }
// //     return array;
// // }

// // System.Console.WriteLine("Input array size: ");
// // int size = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input minimal value: ");
// // int minValue = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input maximal value: ");
// // int maxValue = Convert.ToInt32(System.Console.ReadLine());
// // System.Console.WriteLine("Input number: ");
// // int number = Convert.ToInt32(System.Console.ReadLine());

// // // int[] myArray = CreateRandomArray(size, minValue, maxValue);
// // int[] myArray = CreateUserArray (size);
// // PrintArray(myArray);
// // System.Console.WriteLine(Prisutstvie(number, myArray));


// // ____________________________________________________________________________
// //Задача 2. Напишите программу замена элементов массива: положительные 
// // элементы замените на соответствующие отрицательные, и наоборот.

// //[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] Zamena(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     }
//     return array;

// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int minValue = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int maxValue = Convert.ToInt32(System.Console.ReadLine());


// int[] myArray = CreateRandomArray (size, minValue, maxValue);
// PrintArray(myArray);
// PrintArray(Zamena(myArray));
