// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine($"Задайте (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте (N)");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result = {SumNumbers(m, n)}");

int SumNumbers(int m, int n) {
    if (m == 0) return (n * (n + 1)) / 2;            
    else if (n == 0) return (m * (m - 1)) / 2 * -1;  
    else if (m == n) return m;                       
    else if (m < n) return n + SumNumbers(m, n-1);
    else return n + SumNumbers(n+1, m);            
}    