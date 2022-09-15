// fill matrix
int[,] fillMatrix(int dimension, int minValue, int maxValue)
{
    int[,] arr = new int[dimension, dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        for (int j = 0; j < dimension; j++)
        {
            arr[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

// print matrix
void printMatrix(int[,] arr)
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

// multiply matrix
int[,] multiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    int sum;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(0); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int[,] matr1 = fillMatrix(3, 1, 9);
int[,] matr2 = fillMatrix(3, 1, 9);
printMatrix(matr1);
printMatrix(matr2);
Console.WriteLine("Произведение двух матриц равно:\n");
printMatrix(multiplyMatrix(matr1, matr2));