int n = new Random().Next(1, 65536);
if (n < 100)
{
    Console.WriteLine($"{n} -> третьей цифры нет");
}
else
{
    Console.WriteLine("{0} -> {1}", n, n.ToString()[2]);
}