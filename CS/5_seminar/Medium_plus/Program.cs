bool IsPrime(int number)
{
    bool prime = true;
    for (int i = 2; i <= (int)Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            prime = false;
            break;
        }
    }
    return prime;
}

Console.Write("Введите натуральное число больше 100: ");
string n = Console.ReadLine();
SortedSet<int> subset = new SortedSet<int>();
SortedSet<int> prime_subset = new SortedSet<int>();
for (int i = 0; i < (int)Math.Pow(10, n.Length - 1); i++)
{
    if (n.Contains(Convert.ToString(i))) subset.Add(i);
}
Console.WriteLine($"Число {n} имеет {subset.Count} подчисел -> [{String.Join(", ", subset)}]");
foreach (int i in subset)
{
    if (IsPrime(i) && i > 1) prime_subset.Add(i);
}
Console.WriteLine($"Из них простых {prime_subset.Count} -> [{String.Join(", ", prime_subset)}]");