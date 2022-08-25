// Задать двумерный массив

Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++);
    {
        matrix[i, j] = new Random().Next(-100, 101);
        Console.WriteLine(matrix[i,j] + " ");
    }
    Console.WriteLine();
}