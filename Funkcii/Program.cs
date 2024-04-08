//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата
//новый массив суммы.
//2. Поиска максимального значения массива.
using System;
Random random = new Random();
int[,] mas1 = new int[4, 4];
for (int i= 0;i < mas1.GetLength(0);i++)
{
    mas1[i,0] = random.Next(-50, 50);
    for (int j= 0;j < mas1.GetLength(1);j++)
    {
        mas1[i,j] = random.Next(-50, 50);
        Console.Write(mas1[i, j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
int[,] mas2 = new int[4, 4];
for (int i = 0; i < mas2.GetLength(0); i++)
{
    mas2[i, 0] = random.Next(-50, 50);
    for (int j = 0; j < mas2.GetLength(1); j++)
    {
        mas2[i, j] = random.Next(-50, 50);
        Console.Write(mas2[i,j]+" ");
    }
    Console.WriteLine();
}
int[,] mas = new int[4, 4];

long sum()
{
  for (int i = 0; i < mas.GetLength(0);i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = mas1[i, j] + mas2[i, j];
            return mas[i, j];
        }
        
    }
}
Console.WriteLine(sum(mas1,mas2);
