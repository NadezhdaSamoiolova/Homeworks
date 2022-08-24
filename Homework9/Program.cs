// *** Task 1 *** Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNums1(int min, int max)
// {
//     if (min != max) ShowNums1(min, max - 1);

//     Console.Write(max + " ");
// }

// void ShowNums2(int min, int max)
// {
//     Console.Write(max + " ");
//     if (min != max) ShowNums2(min, max - 1);
// }

// Console.Write("Input first number:  ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number:  ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your numbers are: ");
// if (m < n) ShowNums1(m, n);
// else ShowNums2(n, m);

// *** Task 2*** Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int CountSum(int min, int max)
// {
//     if (min == max) return min;
//     {
//         return min + CountSum(min + 1, max);
//     }
// }

// Console.Write("Input first number:  ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// int min;
// int max;

// if (n < m)
// {
//     min = n;
//     max = m;
// }
// else
// {
//     min = m;
//     max = n;
// }

// Console.WriteLine("Your sum are: " + CountSum(min, max));


// *** Task *** Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

Console.Write("Input first number:  ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number:  ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(m, n);
Console.WriteLine("Your Akkerman is: " + result);