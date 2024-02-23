Random random = new Random();
Console.WriteLine("Введите длину пароля, где 0 - 1 символ, 1 -  2 симвла и т.д : ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n ;i++)
{
    int pass = random.Next(48, 122);
    char strPass = (char)pass;
    Console.Write(strPass +"");
    
}
