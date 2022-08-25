// Задать двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты

Console.Clear();
Console.WriteLine("Задайте двумерный массив m x n");
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        matrix[i, k] = new Random().Next(-100, 101);
        Console.Write(matrix[i, k] + " ");
        if (i%2 == 0 && k%2 == 0)
        {
        Console.Write($"({Math.Pow(matrix[i,k], 2)})  ");

        }
    }
    Console.WriteLine("");
}