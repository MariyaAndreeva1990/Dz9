/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int numberN = ReadInt("Введите число M: ");
int numberM = ReadInt("Введите число N: ");
Console.WriteLine("Сумма натуральных элементов от M до N равна: " + Sum(numberN, numberM));

int Sum(int n, int m)
{
    if (n > m)
        return n + Sum(n - 1, m);
    else if (m > n)
        return m + Sum(m - 1, n);
    else
    return n;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}