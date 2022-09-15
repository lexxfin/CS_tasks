int m = 3, n = 4;
int[,] arr = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = rnd.Next(100);
        Console.Write($"{arr[i, j]}\t");
    }
    Console.WriteLine("\n");
}
Console.Write("Введите строку и столбец элемента массива (например: 2 3): ");
int[] position = Console.ReadLine().Split().Select(i => Convert.ToInt32(i)).ToArray();
if (position[0] > 0 && position[0] <= m && position[1] > 0 && position[1] <= n)
{
    Console.WriteLine($"{String.Join(", ", position)} -> содержит {arr[position[0] - 1, position[1] - 1]}");
}
else Console.WriteLine($"{String.Join(", ", position)} -> такого числа в массиве нет");