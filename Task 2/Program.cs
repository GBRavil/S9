// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine($"Задайте количество строк (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (N)");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = m; i<=n; i++){
    sum +=i;
}
Console.Write($"Сумма элементов от {m} до {n} = {sum}");