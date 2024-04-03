//Задание.
//Напишите функцию, которая принимает два числа и выводит на экран их
//сумму.
//Числа передаются пользователем в переменные, которые затем
//передаются в функцию.
//Функция должна возвращать результат, который в последствии выводится
//на консоль.





Console.Write("Введите первое число: ");
double numberOne = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberToo = double.Parse(Console.ReadLine());
double sum = summOneToo(numberOne, numberToo);
double summOneToo (double x,double y )
{
     return x + y;

}
Console.Write(sum);