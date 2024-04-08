int[] mas  = new int[9];
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(" Введите число: ");
    mas[i] = int.Parse(Console.ReadLine());
    
}
Array.Sort(mas);
foreach (int i in mas)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("Введите число для поиска: ");
int number = int.Parse(Console.ReadLine());
int index = Array.IndexOf(mas, number);
if (index != -1)
{
    Console.WriteLine($"Индекс числа: {number} = {index}"); 
}
else Console.WriteLine("Такого числа нет");
