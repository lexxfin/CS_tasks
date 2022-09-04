Console.Write("Введите количество чисел в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(100);
    if (array[i] % 2 == 0 && i % 2 != 0) sum += array[i];
}
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + sum.ToString());