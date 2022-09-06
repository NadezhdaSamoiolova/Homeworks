// *** ЗАДАЧА *** Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равно три символа.

void ShowArray3Digits(string[] arrString)
{
    Console.Write("[");
    for (int i = 0; i < arrString.Length; i++)
        if (arrString[i].Length <= 3)
        {
            if(i == 0) 
            {
                Console.Write(arrString[i]);
            } else 
            {
                Console.Write(", " + arrString[i]);
            }
        }
    Console.Write("]");
}

Console.WriteLine("Enter stings separated by a comma: ");
string? text = Console.ReadLine();

string[] arrString = text.Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
Console.Write("Your array of strings is: [");
for (int i = 0; i < arrString.Length; i++)
{
    if(i == arrString.Length-1)
            {
               Console.Write(arrString[i]); 
            }
            else Console.Write(arrString[i]+", "); 
}
Console.Write("]");

Console.WriteLine();

Console.Write("Your array of small strings is: ");
ShowArray3Digits(arrString);