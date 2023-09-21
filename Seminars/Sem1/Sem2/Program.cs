// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// using System.Runtime.InteropServices;

// void CheckMultiplicity(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> кратно");
//     }

//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
//     }
// }
// System.Console.WriteLine("Input first num: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input second num: ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// CheckMultiplicity(n1, n2);

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

// int FindBiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if (ed > dec)
//     {
//         return ed;
//     }
//     else
//     {
//         return dec;
//     }
// }


// int num = new Random().Next(10, 100);
// System.Console.WriteLine(num);

// System.Console.WriteLine(FindBiggestDigit(num));


//__________________________________________________________________________________




// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46

// 782 -> 72

// 918 -> 98



// void Reduction()
// {
//     int x = new Random().Next(100, 1000);
//     System.Console.WriteLine(x);
//     int num = ((x / 100) * 10 + x % 10);
//     System.Console.WriteLine(num);
// }

// Reduction();


// _______________________________________________________________________________________________
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да

bool Multiplicity(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Multiplicity(num);
System.Console.WriteLine(result);