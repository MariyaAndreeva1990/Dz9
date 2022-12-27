/*
Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int numberM = ReadInt("Введите положительное число m (не больше 3): ");
int numberN = ReadInt("Введите положительное число n (не больше 5): ");

Console.WriteLine($"m = {numberM}, n = {numberN} -> A({numberM},{numberN}) = {AkkermanFunc(numberM, numberN)}");

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}