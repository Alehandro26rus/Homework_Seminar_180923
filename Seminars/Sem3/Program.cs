// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindCoordinates(int quater)
// {
//     if(quater <= 4 && quater >= 1)
//     {
//         if(quater == 1)
//         {
//             System.Console.WriteLine("x+ y+");
//         }
//         if(quater == 2)
//         {
//             System.Console.WriteLine("x- y+");
//         }
//         if(quater == 3)
//         {
//             System.Console.WriteLine("x- y-");
//         }
//         if(quater == 4)
//         {
//             System.Console.WriteLine("x+ y-");
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("invalid input");
//     }
// }

// System.Console.WriteLine("Input quater num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// FindCoordinates(num);

// ______________________________________________________________
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// ______________________________________________________________

// double FindDistance(double xa, double ya, double xb,  double yb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xa -xb ,2) + Math.Pow(ya -yb ,2)), 2); // этот метод считывает корень из того, что мы еиу передали
// }

// System.Console.WriteLine("Input xA coord: ");
// double xa = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input yA coord: ");
// double ya = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input xB coord: ");
// double xb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Input yB coord: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"A({xa}, {ya}); B({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");
// _____________________________________________________________

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4
// __________________________________________________________
// void Kvadrats(int n)
// {
//     int index = 1;
//     while (index <= n)
//     {
//         System.Console.Write($"{index * index}, ");
//         index++;
//     }
// }
// int Vvod(string msg)
// {
//     System.Console.WriteLine(msg);
//     int num = Convert.ToInt32(System.Console.ReadLine());
//     return num;
// }
//  Kvadrats(Vvod("Введите число: "));

// ____________________________________________________________
// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
// _____________________________________________________________

int Vvod(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;
}

int x = Vvod("Введите координату X: ");
int y = Vvod("Введите координату Y: ");
int Quater (int A, int B)
{
    if (A > 0 && B > 0) return 1;
    if (A < 0 && B > 0) return 2;
    if (A < 0 && B < 0) return 3;
    if (A > 0 && B < 0) return 4;
    else return 0;
}

System.Console.WriteLine(Quater(x, y));

