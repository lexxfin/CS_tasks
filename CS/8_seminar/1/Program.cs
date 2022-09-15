int row = 3, col = 4, sum, minSum = 10000, rowMinSum = 0;
int[,] arr = new int[row, col];
Random rnd = new Random();
Console.WriteLine("\n");
for (int i = 0; i < row; i++)
{
    sum = 0;
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = rnd.Next(10);
        Console.Write($"{arr[i, j]}\t");
        sum += arr[i, j];
    }
    Console.WriteLine("\n");
    if (sum < minSum)
    {
        rowMinSum = i + 1;
        minSum = sum;
    }
}
Console.WriteLine($"{rowMinSum} строка имеет минимальную сумму элементов");