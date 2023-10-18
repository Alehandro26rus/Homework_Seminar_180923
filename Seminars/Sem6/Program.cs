
// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]
// _______________________________________________________________

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// int PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int minValue = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int maxValue = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(System.Console.ReadLine());


// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// myArray = ReverseArray(myArray);
// PrintArray(myArray);

// __________________________________________________________________________

// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101  27->13->6->3->1

// 3 -> 11       11011

// 2 -> 10
// ________________________________________________________________________

// string DecimalToBinary(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;
//     }
//     return result;
// }

// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine(DecimalToBinary(num));
// _________________________________________________________________________
// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

// System.Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool Triangle (int number1, int number2, int number3)
// {
//     if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num2 + num1)) return true;
//     else return false;
// }

// System.Console.WriteLine(Triangle(num1, num2, num3));


// _________________________________________________________________________
// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

public class Sem6_4
{
    public static void Main(string[] args)
    {
        // Выводим приглашение для пользователя ввести значение N.
        Console.Write("Input N: ");
        int N = Convert.ToInt32(Console.ReadLine()); // Считываем введенное пользователем значение и преобразуем его в целое число.

        // Создаем массив fibonachi размером N для хранения чисел Фибоначчи.
        int[] fibonachi = new int[N];

        // Выводим информацию о текущем значении N.
        Console.Write($"Если N = {N} -> ");

        // Вызываем функцию Fibonachi для вычисления чисел Фибоначчи и выводим результат.
        PrintArray(Fibonachi(fibonachi));
    }

    // Функция для вычисления чисел Фибоначчи и заполнения массива fibonachi.
    public static int[] Fibonachi(int[] fibonachi)
    {
        fibonachi[0] = 0; // Первое число Фибоначчи всегда равно 0.
        fibonachi[1] = 1; // Второе число Фибоначчи всегда равно 1.

        // Заполняем массив числами Фибоначчи, начиная с третьего элемента.
        for (int i = 2; i < fibonachi.Length; i++)
        {
            fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2]; // Следующее число Фибоначчи равно сумме двух предыдущих.
        }

        return fibonachi; // Возвращаем массив чисел Фибоначчи.
    }

    // Функция для вывода массива на экран.
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]}, "); // Если первый элемент массива, выводим начало массива.
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}]"); // Если последний элемент массива, выводим конец массива без запятой.
            }
            else
            {
                Console.Write($"{array[i]}, "); // Выводим элемент массива с запятой.
            }
        }
    }
}
