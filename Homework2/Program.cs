// *** Task 1 *** 
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void FindSecondNumber(int num)
// {
//     while(num < 100 || num > 999)
//     {
//         Console.Write("Your number is incorrect. Try again here ");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
//         int digit = num/10 % 10;
//         Console.WriteLine("Your unknown number is " + digit);
// }

// Console.WriteLine("Input a three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindSecondNumber(num);

// *** Task 2 ***
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void FindThirdNum(int num)
// {
//     if (num < 100) Console.WriteLine("The number does not have a third number!");
//     if (num >= 100 && num < 1000) 
//     {
//         int result = num % 10;
//         Console.WriteLine(result);
//     }
//     if (num >= 1000)
//     {
//         string s = num.ToString();
//         int length = s.Length;
//         int result = num / (int)Math.Pow(10, (length - 3)) % 10;

//         Console.WriteLine(result);
//     }
// }

// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindThirdNum(num);

// *** Task 3 ***
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DefineWeekDay(int num)
{
    while (num < 1 || num > 7)
    {
        Console.Write("Your number is incorrect. Try again here ");
        num = Convert.ToInt32(Console.ReadLine());
    }

    if(num >= 1 && num <=5) Console.Write("No");
    if(num == 6 || num == 7 ) Console.Write("Yes");
}

Console.WriteLine ("If you input number from 1 to 7 I'll tell you it is a weekend or not");
Console.WriteLine ("Input your number here: ");
int num = Convert.ToInt32(Console.ReadLine());

DefineWeekDay(num);