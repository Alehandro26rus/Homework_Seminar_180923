// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// ______________________________________________________________________________

// public class Answer
// {
//     static void Power(int A, int B)
//     {
//         int result = 1;

//         for (int i = 1; i <= B; i++)
//         {
//             result *= A;
//         }

//         System.Console.WriteLine(result);
//     }

//     static void Main(string[] args)
//     {
//         System.Console.Write("Введите число A: ");
//         int A = int.Parse(Console.ReadLine());

//         System.Console.Write("Введите степень B: ");
//         int B = int.Parse(Console.ReadLine());

//         Power(A, B);
//     }
// }
// ________________________________________________________________________________
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// _________________________________________________________________________________

// public class Answer
// {
//     static int CalculateDigitSum(int number)
//     {
//         int sum = 0;

//         // Перебираем каждую цифру числа.
//         while (number > 0)
//         {
//             int digit = number % 10; // Получаем последнюю цифру числа.
//             sum += digit; // Добавляем цифру к сумме.
//             number /= 10; // Убираем последнюю цифру из числа.
//         }

//         return sum;
//     }

//     static void Main(string[] args)
//     {
//         System.Console.Write("Введите число: ");
//         int number = int.Parse(Console.ReadLine());

//         int sum = CalculateDigitSum(number);

//         System.Console.WriteLine("Сумма цифр числа: " + sum);
//     }
// }
// ___________________________________________________________________________
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// ___________________________________________________________________________

public class Answer
{
    static void Main(string[] args)
    {
        // Создаем генератор случайных чисел.
        Random random = new Random();

        // Создаем массив из 8 элементов и заполняем случайными числами.
        int[] numbers = new int[8];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 99.
        }

        // Выводим массив на экран.
        Console.Write("Массив: [");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);

            // Добавляем запятую и пробел, если это не последний элемент массива.
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}