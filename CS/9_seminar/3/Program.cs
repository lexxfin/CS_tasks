// Возвращает -1 если m или n меньше нуля
Int128 ackermanFunc(Int128 m, Int128 n)
{
    if (m == 0 && n > 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return ackermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return ackermanFunc(m - 1, ackermanFunc(m, n - 1));
    }
    else return -1;
}

Int128 m = 3, n = 7;
Console.WriteLine($"Для m = {m} и n = {n} Функция Аккермана A(m, n) = {ackermanFunc(m, n)}");