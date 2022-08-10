// *** Task 1. *** Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i<size; i++)
//     newArray[i] = new Random().Next(minValue, maxValue-1);
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//         //Console.WriteLine();
//     }
// }

// int CountEven(int[] array)
// {
//     int count =0;
//     for (int i = 0; i < array.Length; i++)
//     if(array[i] % 2 == 0) 
//     {
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, 100, 1000);
// Console.WriteLine("Your array is: ");
// ShowArray(myArray);

// int count = CountEven(myArray);
// Console.WriteLine();
// Console.WriteLine("Number of even elements is " + count);

// *** Task 2. *** Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i<size; i++)
//     newArray[i] = new Random().Next(minValue, maxValue);
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//         //Console.WriteLine();
//     }
// }

// int CountSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(i % 2 !=0) sum = sum + array[i];
//     }
//     return sum;
// }

// Console.WriteLine("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min Value of array: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input max Value of array: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateArray(size, min, max);
// Console.WriteLine("Your array is: ");
// ShowArray(myArray);

// Console.WriteLine();

// int result = CountSum(myArray);
// Console.WriteLine("Sum of element on odd positions is: " + result);

// *** Task 3. *** Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i<size; i++)
    newArray[i] = new Random().Next(minValue, maxValue);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        //Console.WriteLine();
    }
}

int Difference (int [] array)
{
    int iMax = 0;
    int iMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>array[iMax]) iMax = i;
        else if(array[i]<array[iMin]) iMin = i;
    }
    Console.WriteLine("Max element of array is: " +array[iMax]);
    Console.WriteLine("Min element of array is: " +array[iMin]);
    
    return array[iMax]-array[iMin];
}

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min Value of array: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max Value of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, min, max);
Console.WriteLine("Your array is: ");
ShowArray(myArray);

Console.WriteLine();

int dif = Difference(myArray);
Console.WriteLine("Difference between min and max value of elements is: " + dif);
