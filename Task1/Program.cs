/*Задайте значение N. Напишите программу, которая выведет 
все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int number = ReadInt("Введите число: ");

RevNaturalNumber(number);

void RevNaturalNumber(int n)
{
    int m = 1;
    if (n > m)
    {
        Console.Write($"{n}, ");
        RevNaturalNumber(n - 1);
    }
    if (n == m)
    {
        Console.Write($"{n} ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}