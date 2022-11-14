// Написать программу вычисления функции Аккермана
Console.WriteLine($"Задайте (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте (N)");
int n = Convert.ToInt32(Console.ReadLine());
int Akk(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
Console.WriteLine($"Функция Аккермана = {Akk(m,n)}");