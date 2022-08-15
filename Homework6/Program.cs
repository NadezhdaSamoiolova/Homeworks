// *** Task 1 *** 
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int m)
// {
//     int[] newArray = new int [m];
//     for(int i=0; i<m; i++)
//     {
//         Console.Write($"Input {i+1} elements of {m}: ");
//         newArray[i]=Convert.ToInt32(Console.ReadLine());
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for(int i=0; i<array.Length; i++)
//     Console.Write(array[i]+ " ");
//     Console.WriteLine();
// }

// int CountPositive(int[] array)
// {
//     int count = 0;
//     for(int i=0; i<array.Length; i++)
//     if(array[i]>0) count = count + 1;
//     return count;
// }

// Console.WriteLine("Input size of your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] yourArray = CreateArray(m);
// Console.WriteLine("Your Array is: ");
// ShowArray(yourArray);

// int result = CountPositive(yourArray);
// Console.WriteLine("Number of positive elemensts is: " + result);

// *** Task 2 ***
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input b1 "); 
double b1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input k1 "); 
double k1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input b2 "); 
double b2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input k2 "); 
double k2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine($"Equation of your first line is: y={k1}*x+{b1}");
Console.WriteLine($"Equation of your second line is: y={k2}*x+{b2}");

if (k1 != k2) 
{ 
    double x = ((b2 - b1) / (k1 - k2)); 
    double y = k1 * x + b1; 
    Console.WriteLine($"Point of intersection of your lines has coordinates (X = {x}, Y = {y})"); 
} 
else 
{ 
    if (k1 == k2 && b1 != b2) Console.WriteLine("Your lines are parallel!"); 
    if (k1 == k2 && b1 == b2) Console.WriteLine("Your lines match!"); 
}
