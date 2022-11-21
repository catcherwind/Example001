Console.WriteLine("Введите имя");
string name = Console.ReadLine();

if (name.ToLower == "masha")
{
    Console.WriteLine($"Ура, это же Маша!!!");
}
else
    Console.WriteLine($"Привет, {name}");