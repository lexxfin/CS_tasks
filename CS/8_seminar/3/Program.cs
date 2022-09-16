//fill array
int[,] fillArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();
    HashSet<int> unique = new HashSet<int> { };
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            int num = rnd.Next(10, 100);
            if (unique.Contains(num))
            {
                j--;
            }
            else
            {
                arr[i, j] = num;
                unique.Add(num);
            }
        }
    }
    return arr;
}

//print array
void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] dimension;
bool notCorrectSize;
do
{
    notCorrectSize = false;
    Console.Write("\nВведите число строк и столбцов двумерного массива через пробел, \n(например: 5 6), но размерностью не более 50 элементов: ");
    dimension = Console.ReadLine().Split().Select(i => Convert.ToInt32(i)).ToArray();
    if (dimension[0] * dimension[1] > 50)
    {
        Console.WriteLine("\nРазмерность больше 50 элементов. Уменьшите число строк или столбцов.");
        notCorrectSize = true;
    }
} while (notCorrectSize);
Console.WriteLine();
printArray(fillArray(dimension[0], dimension[1]));
