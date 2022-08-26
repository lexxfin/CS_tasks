int n = new Random().Next(1, 1000001);
if (n % (7 * 23) == 0)
{
    Console.WriteLine($"Число {n} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {n} не кратно 7 и 23 одновременно");
}