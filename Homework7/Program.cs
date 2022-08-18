// *** Task 1 *** Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     double[,] newArray = new double[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round (new Random().NextDouble(),1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double[,] array = CreateRandom2dArray(m, n, min, max);
// Console.WriteLine("Your array is: ");
// Show2dArray(array);

// *** Task 2 *** Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// int x = 0;
// int y = 0;

// bool Findnumber(int[,] array, int num)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (num == array[i, j])
//             {
//                 x = i;
//                 y = j;
//                 return true;
//             }
//         }
//     }

//     return false;
// }



// Console.WriteLine("Input number of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of colums: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(m, n, min, max);

// Console.WriteLine("Your array is: ");
// Show2dArray(array);


// if (Findnumber(array, num))
// {
//     Console.WriteLine("Your number does exists in array and first of them has coordinates: row: " + x + " column: " + y);
// }
// else
// {
//     Console.WriteLine("Your number doesn't exixt in this array");
// }


// ** Task 3 *** Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void FindAverage(int[,] array)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        Console.Write(Math.Round(sum / array.GetLength(0), 2) + "; ");
        sum = 0;
    }
}

int[,] array = CreateRandom2dArray(3, 4, 1, 4);
Console.WriteLine("Your array is: ");
Show2dArray(array);

Console.WriteLine("Averages are: ");
FindAverage(array);