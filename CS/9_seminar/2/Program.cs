int[,] fillSpiral(int[,] array)
{
    int sizeX = array.GetUpperBound(0);
    int sizeY = array.GetUpperBound(1);
    int maxX = sizeX + 1;
    int maxY = sizeY;
    int dirX = 1;
    int dirY = 1;

    int x = -1;
    int y = 0;
    int val = 1;
    while ((maxX >= 0) && (maxY >= 0))
    {
        for (int xval = 1; xval <= maxX; xval++)
        {
            array[y, x + dirX * xval] = val;
            val++;
        }

        x = x + dirX * maxX;
        dirX = -dirX;
        maxX--;

        for (int yval = 1; yval <= maxY; yval++)
        {
            array[y + dirY * yval, x] = val;
            val++;
        }

        y = y + dirY * maxY;
        dirY = -dirY;
        maxY--;
    }

    return array;
}

int[,] arr = new int[4, 4];
fillSpiral(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"\t{arr[i, j]}");
    }
    Console.WriteLine();
}