//Напишите программу, которая выполняет логическое побитовое
//умножение, сложение, шифрование по ключу и инверсию.
//Пользователь вводит число, затем вид операции с числом и получает
//результат в зависимости от своего выбора.

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите действие: '*', '+','~'");
char action = char.Parse(Console.ReadLine());
int act(int x, char y)
{
    int acti = x;
    int res = 0;

    if (y == '*')
    {
        res = x & acti;
    }
    else if (y == '+')
    {
        res = x | acti; 
    }
    else if (y == '~')
    {
        res = ~acti;
    }

    return res;
}



Console.WriteLine(act(n,action));
