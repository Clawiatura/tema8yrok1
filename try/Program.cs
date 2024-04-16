//int a = 10;
//Console.Write("Введите число, на которое нужно разделить: ");
//int b = int.Parse(Console.ReadLine());
//int c = Divide(a,b);
//int Divide (int a, int b)
//{
//    if (b == 0)
//    {
//        throw new DivideByZeroException("Деление на ноль недопустипо");
//    }
//    return a / b;
//}
//Console.WriteLine(c);




//int a = 10;
//int b = 0;
//try
//{
//    int c = a / b;
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Произошла ошибка " + ex.Message);
//}


//int[] number = { 1, 2, 3 };
//try
//{
//    for (int i = 0; i <= number.Length; i++)
//    {
//        Console.WriteLine(number[i]);
//    }
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Выход за пределы масива");
//}


//int[] number = { 1, 2, 3, 4 };
//try
//{
//    for (int i = 0; i < number.Length; i++)
//    {
//        Console.WriteLine(number[5]);
//    }

//}
//catch (IndexOutOfRangeException)
//{
//    Console.WriteLine("Выход за пределы массива" + );
//}
//finally
//{
//    Console.WriteLine("Программа завершена");
//}

try
{
    Console.WriteLine("Введите файл, который хотите найти: ");
    string name = Console.ReadLine();
    if (File.Exists(name))
    {
        Console.WriteLine("Файл найден");
    }
    else

        Console.WriteLine("Файл не найден");

}
catch (FileNotFoundException ex)
{
    Console.WriteLine("Файл не найден" + ex.Message);
}    



