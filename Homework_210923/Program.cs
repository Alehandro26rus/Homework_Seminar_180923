// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondNumber(int num)
{
    return (num / 10) % 10;
}

System.Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{SecondNumber(num)} - вторая цифра числа");

// _________________________________________________________________________________________________________________________________________

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdNumber(int num)
{
    if (num > 999)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        System.Console.WriteLine($"{num} третье число");
    }
    else if (num > 99)
    {
        num = num % 10;
        System.Console.WriteLine($"{num} третье число");
    }
    else
    {
        System.Console.WriteLine($"{num} третьей цифры нет");
    }
}

System.Console.WriteLine("Input num: ");
int n = Convert.ToInt32(Console.ReadLine());
ThirdNumber(n);


// _________________________________________________________________________________________________________________________________________

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int num)
{
    if (num > 5 && num < 8)  // num == 6 || num == 7
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
bool result = Weekend(num);
System.Console.WriteLine(result);