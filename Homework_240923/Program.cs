// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
//     {
//         if (number < 10000 || number > 99999)
//         {
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int originalNumber = number;
//         int reversedNumber = 0;

//         while (number > 0)
//         {
//             int remainder = number % 10;
//             reversedNumber = reversedNumber * 10 + remainder;
//             number /= 10;
//         }

//         return originalNumber == reversedNumber;
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args)
//     {
//         int number;

//         if (args.Length >= 1)
//         {
//             number = int.Parse(args[0]);
//         }
//         else
//         {
//             // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 645546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }
// _____________________________________________________________
// // Внутри класса Answer напишите метод DistanceBetweenPoints,
// // который принимает на вход координаты двух точек pointA и pointB 
// // в виде массива целых чисел, и возвращает расстояние между ними в 
// // 3D пространстве.

// using System;

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже


//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }
// ______________________________________________________________
// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


// N = 3 
/*
1
8
27
*/

// N = 5
/*
1
8
27
64
125
*/

using System;

public class Answer
{
    static void ShowCube(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine(cube);
        }
    }

    // Не удаляйте и не меняйте метод Main!
    static public void Main(string[] args)
    {
        int N;

        if (args.Length >= 1)
        {
            N = int.Parse(args[0]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}