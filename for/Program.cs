using System.ComponentModel.Design;

Random random = new Random();
Console.WriteLine("Введите длину пароля, где 0 - 1 символ, 1 -  2 симвла и т.д : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
    int pass = random.Next(48, 122);
    char strPass = (char)pass;
    Console.Write(strPass + "");

}
int temperature = 0;
for (int i = 0; i <= temperature; i++)
{
    temperature = random.Next(0, 101); Console.WriteLine("Текущая температура:" + temperature);
    {
        if (temperature > 90) Console.WriteLine("Критическая температура!"); break;

    }
}


Console.Write("Укажите количество квадратов: ");  
int quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите сторону квадрата: ");
int weigth = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < quantity; i++) // 1 - проверяется условие, заходим в цикл
{
    for (int j = 0; j < weigth; j++) // 2 - проверяется условие J увеливачаем на +1 и опять проверяем условие
    {
        Console.Write("*"); // 3 Вывод в консоль
        Console.Write(" "); // 3 вывод в консоль
    }
    Console.WriteLine();
    for (int k = 0; k < weigth - 2; k++) // 4 проверяется условие
    {
        Console.Write("*"); // 5 вывод в консоль
        for (int l = 0; l < weigth + weigth - 2; l++) // 6 проверяется условие, l++ и проверяется условие
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine(); //  7 вывод в консоль
    }
    for (int m = 0; m < weigth; m++)  //  8 проверяется условие и заходим в цикл, после выполнения цикла m++ и по кругу
    {
        Console.Write("*");
        Console.Write(" "); // 9 вывод в консоль
    }

    Console.WriteLine();
}
   