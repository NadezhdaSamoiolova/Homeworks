// *** Task 1 *** 
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool IsPolindrom (int num)
// {
//     string s = num.ToString();
//     int length = s.Length;

//     while(length < 5 || length > 5)
//     //while(length !=5)
//     {
//         Console.WriteLine("Your number has more or less then five digits! Try again here: ");
//         num = Convert.ToInt32(Console.ReadLine());
//         s = num.ToString();
//         length = s.Length;
//     }
//         if    (num/10000 == num%10 &&  num/1000 % 10 == num %100 /10) 
//     {
//         return true;
//     } 
//     else 
//     {
//         return false;
//     }
// }

// Console.WriteLine("Input a five-digit-number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = IsPolindrom(num);
// if(result) 
// {
//     Console.WriteLine("It is a Polindrom");
// } 
// else 
// {
//     Console.WriteLine("It is not a Polindrom");
// }

// *** Task 2 *** Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double FindDistanceIn3D(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
//     return distance;
// }

// Console.WriteLine ("Input coordinate x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine ("Input coordinate x2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine ("Input coordinate y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine ("Input coordinate y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine ("Input coordinate z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine ("Input coordinate z2: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double num = FindDistanceIn3D( x1,  y1,  z1,  x2,  y2, z2);
// Console.WriteLine ("Your distance is " + num);

// *** Task 3 *** Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindCube(int num)
{
    int current = 1;
    while(current <= num)
    {
    int num1 = (int)Math.Pow(current, 3);
    Console.Write(num1+", ");
    current++;
    }

}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
FindCube(num);

