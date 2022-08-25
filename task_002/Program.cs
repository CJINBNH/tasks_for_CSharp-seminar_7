// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A = m+n;
// Выведите полученный массив на экран

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        matrix[i, k] = i + k;
        Console.Write(matrix[i, k] + " ");
    }
    Console.WriteLine();
}