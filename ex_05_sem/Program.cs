Console.WriteLine("Введите первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine(n1 % n2 == 0 ? "Число кратно" : $"Число не кратно. Остаток от деления {n1 % n2}");