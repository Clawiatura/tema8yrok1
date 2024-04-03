//Задание.
//Напишите функцию, которая принимает два числа и выводит на экран их
//сумму.
//Числа передаются пользователем в переменные, которые затем
//передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится
//на консоль.





//Console.Write("Введите первое число: ");
//double numberOne = double.Parse(Console.ReadLine());
//Console.Write("Введите второе число: ");
//double numberToo = double.Parse(Console.ReadLine());
//double sum = summOneToo(numberOne, numberToo);

//double summOneToo (double x,double y )
//{
//     return x + y;

//}
//Console.Write(sum);

//Задание.
//Напишите функцию, которая принимает массив целых чисел и возвращает
//среднее значение элементов массива.
//Массив задать явно
//Функция должна возвращать результат, который в последствии выводится
//на консоль.



int[] mas = new int[] {1,2,3,4,5,6,7};



double avg (int[] mas)
{
    double s = 0;
    foreach (var i in mas) s+=i;
    return s/mas.Length;
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i]+ " ");
}
Console.WriteLine(); 
Console.WriteLine($"{avg(mas):F2}");
