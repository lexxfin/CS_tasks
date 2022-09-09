Console.Write("Введите коэффициенты первой прямой через пробел (например, для y = 5x-4 нужно ввести 5 -4): ");
double[] firstLine = Console.ReadLine().Split().Select(b => double.Parse(b)).ToArray();
Console.Write("Введите коэффициенты второй прямой через пробел (например, для y = -x+7 нужно ввести -1 7): ");
double[] secondLine = Console.ReadLine().Split().Select(b => double.Parse(b)).ToArray();
double[] crossPoint = new double[2];
if (firstLine[0] != secondLine[0])
{
    crossPoint[0] = (secondLine[1] - firstLine[1]) / (firstLine[0] - secondLine[0]);
    crossPoint[1] = firstLine[0] * crossPoint[0] + firstLine[1];
    Console.WriteLine($"Прямые пересекаются в точке ({crossPoint[0]}; {crossPoint[1]})");
}
else if (firstLine[1] == secondLine[1]) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны");