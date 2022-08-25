// Задать двумерный массив. Найти сумму элементов, находящихся на главной диагонали.

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
double res = 0;
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        matrix[i, k] = new Random().Next(-100, 101);
        if (i == k)
        {
        res = res + matrix[i, k];
        }
        Console.Write(matrix[i, k] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали массива равна {res}");