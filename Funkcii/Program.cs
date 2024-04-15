//Проинициализируйте вручную два массива 4х4, значениями от -50 до 50.
//Напишите функции:
//1.Суммирующую массивы и возвращающую в качестве результата
//новый массив суммы.
//2. Поиска максимального значения массива.







Random random = new Random();

int[,] mas1 = new int[4, 4];
for (int i = 0; i < mas1.GetLength(0); i++)
{
mas1[i, 0] = random.Next(-50, 50);
for (int j = 0; j < mas1.GetLength(1); j++)
{
mas1[i, j] = random.Next(-50, 50);
Console.Write(mas1[i, j] + " ");
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
        Console.Write(mas2[i, j] + " ");
    }
    Console.WriteLine();
}
    int[,] sum(int[,] mas, int[,] mas1)
    {
        int rows = mas.GetLength(0);
        int cols = mas1.GetLength(1);
        int[,] result = new int[4, 4];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = mas[i, j] + mas1[i, j];

            }

        }
        return result;

    }
Console.WriteLine("\n");
int[,] result = sum(mas1, mas2);
for (int r = 0; r < result.GetLength(0); r++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[r, j] + " ");
    }
    Console.WriteLine();
}

for (int r = 0; r < result.GetLength(0); r++)
{
    
    for (int j = 0; j < result.GetLength(1); j++)
    {
        
        int res = MaxNumber(result[r,j]);
        Console.Write(res); break;
        // Не могу понять, как сделать так, чтобы он просто нашел одно наибольшее число и вывел его

    }
    Console.WriteLine();
}

int MaxNumber(int x)

    {
        int maxvalue = 0;
        int[,] result = sum(mas1, mas2);

    foreach (int a in result)
        {
            maxvalue = maxvalue< a ? a : maxvalue;
        }
    return maxvalue;
    }


















