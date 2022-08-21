// *** Task 1 *** Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
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

// void SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int size = array.GetLength(1);
//         // int min = array[i,jMin];
//         int temp;

//         while (size > 1) 
//         {
//             int jMin= 0;
//             for (int j = 0; j < size; j++)
//             {
//                 if (array[i, j] < array[i,jMin])
//                 {
//                     jMin = j;
//                 }
//             }
//             temp = array[i, size - 1];
//             array[i, size - 1] = array[i, jMin];
//             array[i, jMin] = temp;
//             size--;
//         }
//     }
// }

// int[,] array = CreateRandom2dArray(4, 5, 1, 9);
// Show2dArray(array);

// Console.WriteLine();

// SortArray(array);

// Show2dArray(array);
// Show2dArray(newArray);
// Console.Write(array);
//Console.WriteLine(newArray);


// *** Task 2*** Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
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

// int FindMinLine (int[,] array)
// {
//     int sum = 0;
//     int minSum = 0;
//     int minLine = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (i == 0) 
//         {
//             minSum = sum;
//             minLine = i;
//             }
//         else 
//         {
//             if (sum < minSum) 
//             {
//             minSum = sum;
//             minLine = i;
//             }
//         }
//         sum = 0;
//     }
//     return minLine;
// }

// int[,] array = CreateRandom2dArray(4, 4, 1, 4);
// Console.WriteLine("Your array is: ");
// Show2dArray(array);

// Console.WriteLine("MinLine: ");
// int line = FindMinLine(array);
// Console.WriteLine(line+1);

// *** Task 3. Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)

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

// int[,] FindMultiplyArray(int[,] array1, int[,]array2)
// {
//     int[,]newArray = CreateRandom2dArray(3, 3, 0, 0);
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array1.GetLength(1); j++)
//         {
//             newArray[i, j] = array1[i,j] * array2[i,j];
//         }
//     }
//     return newArray;
// }

// int [,] array1 = CreateRandom2dArray(3, 3, 2, 5);
// Show2dArray(array1);

// Console.WriteLine();

// int [,] array2 = CreateRandom2dArray(3, 3, 2, 5);
// Show2dArray(array2);

// Console.WriteLine("Your new array is: ");

// Show2dArray(FindMultiplyArray(array1, array2));

// *** Task 4 *** Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] CreateRandom3dArray(int rows, int columns, int high, int minValue, int maxValue)
// {
//     int[,,] newArray = new int[rows, columns, high];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             for (int k = 0; k < high; k++)
//             {
//                 newArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//             }
//         }
//     }
//     return newArray;
// }

// void Show3dArray(int[,,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i, j, k] + " (" + i + ", " + j + ", " + k + " )");
//             }
//                 Console.WriteLine();
//         }
//     }
// }


// int [,,] array3d = CreateRandom3dArray(2,2,2, 10, 99);
// Show3dArray(array3d);

// *** Task 5 *** Задача 62. Заполните спирально массив 4 на 4.

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    int num = 1;
    int size_i = newArray.GetLength(0);
    int size_j = newArray.GetLength(1);

    int row = 0;
    int column = 0;

    bool isRow = true;
    bool isRight = true;
    bool isDown = true;

    int spiralTotal = 0;

    if (rows >= columns)
    {
        spiralTotal = columns * 2;
    }
    else
    {
        spiralTotal = rows * 2 - 1;
    }

    for (int spiral = 0; spiral < spiralTotal; spiral++)
    {
        if (isRow && isRight)
        {
            for (int j = row; j < size_j; j++)
            {
                newArray[row, j] = num++;
            }
            isRow = false;
            isRight = false;
            row++;
        }
        else if (!isRow && isDown)
        {
            for (int i = row; i <= size_i - 1; i++)
            {
                newArray[i, size_j - 1] = num++;
            }
            isRow = true;
            isDown = false;
            size_j--;
        }
        else if (isRow && !isRight)
        {
            for (int j = size_j - 1; j >= column; j--)
            {
                newArray[size_i - 1, j] = num++;
            }
            isRow = false;
            isRight = true;
            size_i--;
        }
        else if (!isRow && !isDown)
        {
            for (int i = size_i - 1; i >= row; i--)
            {
                newArray[i, column] = num++;
            }
            isRow = true;
            isDown = true;
            column++;
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

Console.WriteLine("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your array is: ");

int[,] myArray = CreateRandom2dArray(m, n);

Show2dArray(myArray);

