Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b)
{
    Console.WriteLine("Оба числа одинаковы");
}
if(a > b)
{
    Console.WriteLine("Максимальное число: " + a);
}
if(a < b)
{
    Console.WriteLine("Максимальное число: " + b);
}