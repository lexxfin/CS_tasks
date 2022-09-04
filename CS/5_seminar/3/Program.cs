Console.Write("Введите количество чисел в массиве: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
int index_of_min = 0;
int index_of_max = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rnd.Next(1, 100);
    if (array[i] > array[index_of_max]) index_of_max = i;
    else if (array[i] < array[index_of_min]) index_of_min = i;
}
Console.WriteLine("[" + String.Join(", ", array) + "] -> " + (array[index_of_max] - array[index_of_min]).ToString());