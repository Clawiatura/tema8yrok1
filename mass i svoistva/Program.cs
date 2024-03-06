//Домашнее задание. Тема 15. Урок 3. Свойства и методы
//одномерных массивов.


//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i < mas.Length; i++)
//{
//    Array.Sort(mas);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();

//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int index = Array.IndexOf(mas, number);
//if (index != -1) Console.WriteLine($"Индекс числа {number} = {index}");
//else Console.WriteLine("Такого числа нет");

// Домашнее задание. Тема 15. Урок 4. Свойства и методы
//одномерных массивов. Тип Object.

int[] mas = new int[2];
int[] mas1 = new int[2];
int[] mas2 = new int[2];
int[] mas3 = new int[2];
Random random = new Random();

for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(10);
    Console.Write(mas1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = random.Next(10);
    Console.Write(mas2[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i] = random.Next(0, 10);
    Console.Write(mas3[i] + " ");
}
Console.WriteLine();
int[] mas4 = mas.Concat(mas1).ToArray();
double sum = 0;
foreach (int i in mas4)
{
    sum += i;
    Console.Write(i+" ");
}
Console.WriteLine();
int[] mas5 = mas2.Concat(mas3).ToArray();
double sum1 = 0;
foreach (int i in mas5)
{
    sum1 += i;
    Console.Write(i + " ");
}
Console.WriteLine();

Console.WriteLine($"AVG 1.2 masiva: {sum/mas4.Length:F2} AVG 3.4 masiva: {sum1/mas5.Length:F2}");
Console.WriteLine($"multiplication: {sum/mas4.Length * sum1 / mas5.Length:F2}");
//



