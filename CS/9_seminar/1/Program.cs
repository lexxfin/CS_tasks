int row = 3, col = 4;
int[,] arr = new int[row, col];
Random rnd = new Random();
Console.WriteLine($"\nИсходный массив размером {row} на {col}\n");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = rnd.Next(25);
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"\nМассив с отсортированными строками по убыванию\n");
int[] tmp = new int[col];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        tmp[j] = arr[i, j];
    }
    Array.Sort(tmp);
    Array.Reverse(tmp);
    for (int j = 0; j < col; j++)
    {
        arr[i, j] = tmp[j];
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine();
}