// ***Task 1***
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Your first number("+ num1 +") is bigger than your second number("+ num2+")");
}
else
{
    Console.WriteLine("Your second number("+ num2 +") is bigger than your first number("+ num1 +")");
}

// ***Task 2***
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input third number ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)  max = num2;
// if (num3 > max)  max = num3;


// Console.WriteLine($"Yur number is {max}");

// ***Task 3***
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0) 
// {
//     Console.WriteLine("Your number is an even number");
// }
// else 
// {
//     Console.WriteLine("Your number is an odd number");
// }

// ***Task 4***
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input number ");
// int N = Convert.ToInt32(Console.ReadLine());

// int current = N * (-1);

// while (current <= N) 
// {
//     if (current % 2 == 0)
//     Console.Write(current + " ");
//     current++;
// }


//***** А теперь то же самое, с использованием метода *****
// ***Task 1***
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


