//Написать программу показывающие первые N чисел, 
//для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем
Console.WriteLine($"Задайте (N)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте первый элемент");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте второй элемент");
int second = Convert.ToInt32(Console.ReadLine());

PrintNumber(first, second, n);
void PrintNumber(int first, int second, int n)
{
    int temp = 0;
    if (n > 0)
    {
        Console.Write(first + second + " ");
        temp = first;
        first = second;
        second += temp;
        PrintNumber(first, second, n -= 1);
    }
}