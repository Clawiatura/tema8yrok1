﻿string[,] mas ={
    {"","","x","x","",""},
    {"","x","","","x",""},
    {"x","","","","","x"},
    {"","x","x","x","x",""},
    {"","","x","x","",""},
    {"","","x","x","",""},
    {"","","x","x","",""},
    {"","","x","x","",""},
    {"","","x","x","",""},
    {"","","x","x","",""},
    {"","x","x","x","x",""}};
string answer = "no"; bool isChecked = false;
do
{
    Console.Clear();
    for (int j = 0; j < mas.GetUpperBound(0) + 1; j++)
    {
        for (int l = 0; l < mas.GetUpperBound(1) + 1; l++)
        {
            if (mas[j, l] != null)
            {
                Console.Write($"{mas[j, l],2}");
            }
        }
        Console.WriteLine();
    }
    if (isChecked == false) Console.Write("Включить лампочку?");
    else Console.Write("Выключить лампочку?");
    answer = Console.ReadLine()!;
    if (answer == "yes") isChecked = !isChecked;
    if (isChecked)
    {
        mas[1, 2] = "x"; mas[1, 3] = "x";
        mas[2, 2] = "x"; mas[2, 3] = "x";
        mas[2, 1] = "x"; mas[2, 4] = "x";
    }
    else
    {
        mas[1, 2] = ""; mas[1, 3] = "";
        mas[2, 2] = ""; mas[2, 3] = "";
        mas[2, 1] = ""; mas[2, 4] = "";
    }
}
while (true);
