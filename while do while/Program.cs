Random random = new Random();
int a = random.Next(1, 6);
int i = 3;
while (i > 0)
{
    Console.WriteLine("Введите число : ");
    int b = int.Parse(Console.ReadLine());
    if (b == a) Console.WriteLine("Вы победили!"); break;
} i--;
{
    if (i > 0) Console.WriteLine($"ВЫ не угадали осталось {i} попыток");
    else Console.WriteLine($"Ты проиграл, число {a}");
} 