Console.Write("Введите количество чисел в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < n; i++) array[i] = rnd.Next(15);
for (int i = 0; i < n / 2; i++) sum += array[i] * array[n - i - 1];
Console.WriteLine($"[{String.Join(", ",array)}] -> {sum}");