//Задание 1. Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2
// ___________________________________________________________________

/*
static int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    Random random = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++) // Исправлено условие
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return array;
}

static void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) // Исправлено условие
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[,] ChangeArrayRows(int[,] array, int row1, int row2)
{
    if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        System.Console.WriteLine("Index of row is out of bound!");
        return array;
    }
    else
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (rows, columns, row1, row2);
Print2DArray(myArray);
Print2DArray(ChangeArrayRows(myArray, row1, row2));
*/

// ______________________________________________________________________
//Задание 2. Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение 
// для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
// ____________________________________________________________________

/*
static int[,] Create2DRandomArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    Random random = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++) // Исправлено условие
        {
            array[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return array;
}

static void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) // Исправлено условие
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    System.Console.WriteLine();
}


int[,] ChangeArrayRows(int[,] array, int row1, int row2)
{
    if (row1 >= array.GetLength(0) || row2 >= array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        System.Console.WriteLine("Index of row is out of bound!");
        return array;
    }
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    return array;
}

int[,] RowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        System.Console.WriteLine("Invalid array!");
        return array;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(0); j++) 
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
            
        }
    }
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, columns, row1, row2);
Print2DArray(myArray);
Print2DArray(RowsToColumns(myArray));
*/

// _______________________________________________________________________
//Задание 3. Из двумерного массива целых чисел удалить строку и 
// столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

int[,] ModifiedArray(int[,] array)
{
    int min = array[0, 0];
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (min >= array[i, j])
            {
                min = array[i, j]
                imin = i;
                jmin = j;
            }
        }
        System.Console.WriteLine(array[imin, jmin]);
        for (int j = 0; j < array.GetLength(0); j++) array[imin, j] = 0
        for (int i = 0; i < array.GetLength(0); i++) array[jmin, i] = 0
        return array;
    }