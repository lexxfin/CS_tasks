int row = 3, col = 4, sum;
int[,] arr = new int[row, col];
Random rnd = new Random();
Console.WriteLine("\n");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = rnd.Next(100);
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine("\n");
}
Console.WriteLine("Среднее арифметическое каждого столбца\n");
for (int j = 0; j < col; j++)
{
    sum = 0;
    for (int i = 0; i < row; i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{Math.Round((double)sum / row, 2)}\t");
}
Console.WriteLine("\n");