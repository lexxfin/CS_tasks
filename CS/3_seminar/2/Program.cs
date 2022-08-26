Console.Write("Введите координаты первой точки через пробел (например: 3 -2 6): ");
string[] nums_str = Console.ReadLine().Split();
int[] a = new int[nums_str.Length];
for (int i = 0; i < nums_str.Length; i++)
{
    a[i] = Convert.ToInt32(nums_str[i]);
}
Console.Write("Введите координаты второй точки через пробел (например: -3 2 0): ");
nums_str = Console.ReadLine().Split();
int[] b = new int[nums_str.Length];
for (int i = 0; i < nums_str.Length; i++)
{
    b[i] = Convert.ToInt32(nums_str[i]);
}
Console.Write("Расстояние между точками равно: ");
Console.WriteLine(Math.Sqrt(Math.Pow(b[0] - a[0], 2) + Math.Pow(b[1] - a[1], 2) + Math.Pow(b[2] - a[2], 2)));