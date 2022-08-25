Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if((num1 == num2) && (num2 == num3))
{
    Console.WriteLine("Все числа одинаковы");
}
if((num1 > num2) && (num1 > num3))
{
    Console.WriteLine("Максимальное число: " + num1);
}
if((num2 > num1) && (num2 > num3))
{
    Console.WriteLine("Максимальное число: " + num2);
}
if((num3 > num2) && (num3 > num1))
{
    Console.WriteLine("Максимальное число: " + num3);
}