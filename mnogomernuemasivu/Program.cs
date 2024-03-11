int[] mas1 = new int[] { 1, 2, 3 };
int[] mas2 = new int[] { 4, 5, 6 };
int[] mas3 = new int[] { 7, 8, 9, 10 };
int[,,] mas4 = new int[3, 3, 4];
for (int i = 0; i < mas1.Length; i++)
{
mas4[i, 0, 0] = mas1[i];
for (int j = 0; j < mas2.Length; j++)
{
mas4[i, j, 0] = mas2[j];
for (int k = 0; k < mas2.Length; k++)
{
mas4[i, j, k] = mas3[k];
}
}
}
for (int k = 0; k < mas4.GetLength(2); k++)
{
for (int i = 0; i < mas4.GetLength(0); i++)
{
for (int j = 0; j < mas4.GetLength(1); j++)
{
Console.Write(mas4[i, j, k] + " ");
}
Console.WriteLine();
}
Console.WriteLine();
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

mas4[0, 2, 0] = number;
for (int k = 0; k < mas4.GetLength(2); k++)
{
    for (int i = 0; i < mas4.GetLength(0); i++)
    {
        for (int j = 0; j < mas4.GetLength(1); j++)
        {
            Console.Write(mas4[i, j, k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//Создайте массив из трех одномерных массивов. [3][ ]
//Заполните его значениями чисел от 1 до 10 (можно вручную, можно
//рандомом)
//Далее добавьте вывод всех значений массива.
//каждый одномерный массив выводится построчно в консоль
//Далее выведите сумму каждого одномерного массива
//*Выведите в конце среднее арифметическое всех значений массива.


//int[][][] mas = new int[3][][];
//mas[0] = new int[] { 1 , 2 , 3 };
//mas[1] = new int[] { 4 , 5 , 6 };
//mas[2] = new int[] { 7 , 8 , 9 };









