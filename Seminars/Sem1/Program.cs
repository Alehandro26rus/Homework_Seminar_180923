/*
System.Console.WriteLine("Input number: ");
Данное число надо куда-то записать, в какую переменную
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Your num is -> " + num);
*/

/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Quad of {num} ->  {num * num}");
*/


/*
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 * num2 == num1)
{
    System.Console.WriteLine($"{num1} является квадратом {num2}");
}
else
{
    System.Console.WriteLine($"{num1} не является квадратом {num2}");
}
*/



/* Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
 2 -> " -2, -1, 0, 1, 2"

 // Задача 4.  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.
    
    456 -> 6 
    
    782 -> 2
    
    918 -> 8
 */


 /*
 System.Console.WriteLine("Input N: ");
 int n = Convert.ToInt32(Console.ReadLine());

 int count = -n;
 while (count < n+1)

 {
    System.Console.WriteLine(count++);
 }
 */


 /*
 System.Console.WriteLine("Input N: ");
 int num = Convert.ToInt32(Console.ReadLine());

 if(num >= 100 && num<=999)
 {
    System.Console.WriteLine($"Last digit of {num} -> {num%10}");
 }
else
{
    System.Console.WriteLine("You input not three-digit number");
}
*/