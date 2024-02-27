//string[] mas = new string[12];
//mas[0] = "освоении";
//mas[1] = "остальное";
//mas[2] = "по плечу";
//mas[3] = "сложный";
//mas[4] = "но если";
//mas[5] = "програмирование";
//mas[6] = "многие бросают";
//mas[7] = "остальное будет";
//mas[8] = "освоить их";
//mas[9] =  "этап в";
//mas[10] = " на этом этапе";
//mas[11] = "Массивы - ";
//for(int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//string[] mas2 = {"Массивы - ", "сложный", " этап в", "програмирование", "многие бросают", "но если освоить их", "остальное будет", "по плечу" };
//for(int i = 0;i < mas2.Length; i++)
//{
//    Console.Write(mas2[i] + " ");
//}


//int[] mas = new int[10];
//Random random = new Random();
//int a = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(0, 20);
//    Console.Write(mas[i] + " ");
//}
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i]%2 == 0)
//        {
//            a++;
//        }

//    }



//Console.WriteLine();
//Console.WriteLine(a);






int a;
double Sum = 0;
int CountGreat10 = 0;
int CountLess10 = 0;
double avg = 0;
int min;
int max;
Console.Write("Введите 1 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
min = a;
max = a;

Console.Write("Введите 2 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;

Console.Write("Введите 3 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;

Console.Write("Введите 4 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a; 
if (a > max) max = a; 


Console.Write("Введите 5 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;


Console.Write("Введите 6 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a; 
if (a > max) max = a;


Console.Write("Введите 7 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;


Console.Write("Введите 8число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;


Console.Write("Введите 9 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;


Console.Write("Введите 10 число:");
a = int.Parse(Console.ReadLine());
Sum += a;
CountGreat10 = (a > 10) ? ++CountGreat10 : CountGreat10;
CountLess10 = (a < 10) ? ++CountLess10 : CountLess10;
if (a < min) min = a;
if (a > max) max = a;

Console.WriteLine("Sum=" + Sum);
Console.WriteLine( "Числа большие десяти:" + CountGreat10);
Console.WriteLine( "Числа меньшие десяти"+ CountLess10);
Console.WriteLine("AVG=" + (Sum / 4));
Console.WriteLine(min);
Console.WriteLine(max);

