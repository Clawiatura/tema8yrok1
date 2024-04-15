//Напишите программу, которая выполняет логическое побитовое
//умножение, сложение, шифрование по ключу и инверсию.
//Пользователь вводит число, затем вид операции с числом и получает
//результат в зависимости от своего выбора.

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите действие: '*', '+','~','^'");
char action = char.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
int act(int x, int y)
{
    
    int res = 0;

    if (action == '*')
    {
        res = x & y;
    }
    else if (action == '+')
    {
        res = y | x;
    }
    else if (action == '~')
    {
       res = ~x+~y;
    }
    else if (action == '^')
    {
        res = x ^ y;
    }

    return res;
}



Console.WriteLine(act(x,y));
