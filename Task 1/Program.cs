// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine($"Задайте количество строк (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Задайте количество столбцов (N)");
int n = Convert.ToInt32(Console.ReadLine());
if(m<n){
    for(int i = m; i<=n; i++){
        Console.Write($"{i} ");
    }
} else {
    for(int i = n; i<=m; i++){
        Console.Write($"{i} ");
    }
}
