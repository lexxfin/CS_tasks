Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int tmp = n;
int sum = 0;
while (tmp > 0 && tmp % 10 != 0)
{
    if (n % (tmp % 10) == 0)
    {
        sum += tmp % 10;
    }
    tmp /= 10;
}
Console.WriteLine($"{n} -> {sum}");