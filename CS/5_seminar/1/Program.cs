Console.Write("Введите количество чисел в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
int count_of_even = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(100, 1000);
    if (array[i] % 2 == 0) count_of_even++;
}
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + count_of_even.ToString());