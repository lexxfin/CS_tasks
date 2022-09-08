Console.Write("Введите количество чисел М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[M];
int countOfPositive = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
    if (nums[i] > 0) countOfPositive++;
}
Console.WriteLine("[" + String.Join(", ", nums) + $"] -> {countOfPositive}");