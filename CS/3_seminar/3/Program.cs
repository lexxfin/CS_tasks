Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] n_cube = new int[n];
for (int i = 1; i <= n; i++)
{
    n_cube[i - 1] = (int)Math.Pow(i, 3);
    Console.Write("{0} ", n_cube[i - 1]);
}