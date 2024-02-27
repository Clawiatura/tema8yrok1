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


int[] mas = new int[10];
Random random = new Random();
int a = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(0, 20);
    Console.Write(mas[i] + " ");
}
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i]%2 == 0)
        {
            a++;
        }

    }
    


Console.WriteLine();
Console.WriteLine(a);
