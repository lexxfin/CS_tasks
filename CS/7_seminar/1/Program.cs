int m = 3, n = 4;
double[,] arr = new double[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = (double)rnd.Next(-100, 100) / 10;
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}