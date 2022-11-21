Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int i = -(Math.Abs(n));
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}