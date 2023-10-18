Console.Clear();
/*
Задача 1. Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N. Рекурсия.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

/*
void ShowNumbers(int n)
{
    if (n >= 1)
    {
        ShowNumbers(n - 1);
        System.Console.Write(n + " ");
    }
}

ShowNumbers(5);

*/

// ________________________________________________________________________
/*
Задача 2. Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр. Рекурсия.

453 -> 12
45 -> 9
*/

/*
int FindSum(int num)
{
    if (num > 0)
    {
        return FindSum(num / 10) + num % 10;
    }
    else return num;
}
System.Console.WriteLine(FindSum(456));

*/

// __________________________________________________________________

/*
Задача 3. Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. Рекурсия.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

/*
void ShowNumbers2(int n, int m)
{
    if (n != m)
    {
        if (n > m) 
        {
            ShowNumbers2(n - 1, m);
            System.Console.Write(n + ", ");
        }
        else
        {
            ShowNumbers2(n, m - 1);
            System.Console.Write(m + ", ");
        }
    }
    else System.Console.Write($"{n}, ");
}

int n = 1;
int m = 5;
ShowNumbers2(n, m);

*/


// ___________________________________________________________________
/*
Задача 4.Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии. Рекурсия.

A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Power(int A, int B)
{
    if (B == 0) return 1;
    
    return A * Power(A, B - 1);
}

int A = 2;
int B = 3;

int result = Power(A, B);
System.Console.WriteLine($"{A} raised to the power of {B} is {result}");
