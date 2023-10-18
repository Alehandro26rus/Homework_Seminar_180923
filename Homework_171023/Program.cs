Console.Clear();
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

/*
void PrintNumbersFromNto1(int N)
{
    if (N >= 1)
    {
        System.Console.Write(N);
        if (N > 1)
        {
            System.Console.Write(", ");
        }
        PrintNumbersFromNto1(N - 1);
    }
}

int N = 5;
PrintNumbersFromNto1(N); // Выведет "5, 4, 3, 2, 1"
*/

// ____________________________________________________________________________

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumNaturalNumbersInRange(int M, int N)
{
    if (M > N)
    {
        return 0;
    }

    return M + SumNaturalNumbersInRange(M + 1, N);
}

int M = 1;
int N = 15;
int result = SumNaturalNumbersInRange(M, N);
System.Console.WriteLine(result); // Выведет "120"

*/

// ____________________________________________________________________________

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
int Ackermann(int m, int n)
{
    // Базовый случай: если m равно 0, возвращаем n + 1
    if (m == 0)
    {
        return n + 1;
    }
    // Если m больше 0 и n равно 0, вызываем Ackermann с m - 1 и 1
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    // Если m и n больше 0, вызываем Ackermann с m - 1 и результатом Ackermann(m, n - 1)
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    // Обработка ошибки, если значения m или n не являются неотрицательными.
    return -1;
}

int m1 = 2;
int n1 = 3;
int result1 = Ackermann(m1, n1);
System.Console.WriteLine($"A({m1}, {n1}) = {result1}"); // Выведет "A(2, 3) = 9"

int m2 = 3;
int n2 = 2;
int result2 = Ackermann(m2, n2);
System.Console.WriteLine($"A({m2}, {n2}) = {result2}"); // Выведет "A(3, 2) = 29"
*/