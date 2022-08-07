// *** Task 1. Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Вариант решения 1 - в одно действие (без использования цикла)

// int Involute (int num1, int num2)
// {
//     int result = (int)Math.Pow(num1, num2);
//     return result;
// }

// Console.WriteLine("Input your first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input your second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = Involute(num1, num2);
// Console.WriteLine("Your result is: " + result);

// *** Task 1. Вариант решения 2 - с использованием цикла (как просят в условиях задачи)

// int Involute (int num1, int num2)
// {
//     int result = num1;
//     int i = 2;
    
//     while(i <= num2)
//     {
//         result *= num1;
//         i++;
//     }
//     return result;
// }

// Console.WriteLine("Input your first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input your second number > 0: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// while(num2<=0)
// {
//     Console.WriteLine("Your second number is wrong!");
//     Console.WriteLine("Input your number > 0: ");
//     num2 = Convert.ToInt32(Console.ReadLine());
// }


// int result = Involute(num1, num2);
// Console.WriteLine("Your result is: " + result);

// *** Task 2. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int FindSumOfDigits (int num)
// {
//     string s = num.ToString();
//     int count = s.Length;

//     int i = 1;
//     int sum = 0;

//     while(i <= count)
//     {
//         int nummer = num / (int)Math.Pow(10, (count -i)) % 10;
//         sum = sum + nummer;
//         i++;
//     }

//     return sum;
// }


// Console.WriteLine("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = FindSumOfDigits(num);
// Console.WriteLine("Your result is " + result);

// *** Task 3. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int size)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i+1} element of {size}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array.Length; i++)
    Console.Write(array [i] + " ");
    
}

int [] Array = CreateArray(8);
ShowArray(Array);
