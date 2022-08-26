Console.Write("Введите цифру дня недели (например, 1 это понедельник) ");
int n = Convert.ToInt32(Console.ReadLine());
if ((n == 6) || (n == 7))
{
    Console.WriteLine("да");
}
else if ((n >= 1) && (n <= 5))
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("Введено число не соответствующее дню недели");
}