Console.Write("Введите количество генерируемых интересных чисел: ");
int n = int.Parse(Console.ReadLine());
int[] interesting_numbers = new int[n];
int num, tmp, sum, mult;
for (int i = 0; i < n; i++)
{
    do
    {
        //Числа взял до 10000 для простоты проверки вручную
        num = new Random().Next(10000);
        tmp = num;
        sum = 0;
        mult = 1;
        while (tmp > 0)
        {
            sum += (tmp % 10);
            mult *= (tmp % 10);
            tmp /= 10;
        }
        //Строку ниже можно раскомментировать и тогда будут видны все генерируемые случайные числа
        //Console.WriteLine($"num = {num} mult = {mult} sum = {sum} % = {mult % sum}");
    } while (mult % sum != 0);
    interesting_numbers[i] = num;
}
Console.WriteLine(String.Join(", ", interesting_numbers));