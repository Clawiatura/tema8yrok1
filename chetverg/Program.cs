//int CountWords(string text)
//{
//    string[] mas = text.Split(' ');
//    return mas.Length;
//}
//Console.Write("Введите предложение:  ");
//string str  = Console.ReadLine();
//Console.WriteLine(CountWords(str));


//long Factorial(int x)
//{
//    long F = 1;
//    for (int i = 1; i <= x; i++) F*= i;
//    return F; 
//}
//Console.Write("Введите число: ");
//int n;
//int.TryParse(Console.ReadLine(), out n);
//Console.WriteLine($"Факториал {n} = {Factorial(n)}");


//void PrinMatrix(int[,] mas)
//{
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write(mas[i,j]+" ");
//        }
//        Console.WriteLine();
//    }
//}
//Random random = new Random();
//int[,] mas = new int[random.Next(5,10),random.Next(5,10)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = random.Next(10, 100);
//    }
//}
//PrinMatrix(mas);

//string[] UnuqueWords(string[] text)
//{
//    string[] result = new string[text.Length];
//    int i = 0;
//    foreach(var item in text)
//    {
//        if(!result.Contains(item)) result[i++] = item;

//    }
//    return result;
//}
//string[] mas = new string[6];
//Console.Write("Введите слова: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Console.ReadLine();
//}
//string[] res = UnuqueWords(mas);
//foreach(string s in res) Console.Write(s+" ");
//Console.WriteLine();


//double Square(double a, double b,double c)
//{
//    double pp=(a+b+c)/2;
//    return Math.Sqrt(pp*(pp-a)*(pp-b)*(pp-c));
//}

//double a,b,c;
//Console.Write("Введите а: ");
//double.TryParse(Console.ReadLine(), out a);
//Console.Write("Введите b: ");
//double.TryParse(Console.ReadLine(), out b);
//Console.Write("Введите c: ");
//double.TryParse(Console.ReadLine(), out c);
//Console.WriteLine($"Площадь:{Square(a,b,c):F2}");

//bool FindWord(string text,string word)
//{
//    return text.Contains(word);
//}



Random random = new Random();
int[] mas1 = new int[random.Next(5,10)];
int[] mas2 = new int[random.Next(5,10)];
void FillArray(int[] mas)
{
    for (int i = 0; i < mas.Length; i++) 
        mas[i] = random.Next(10,100);
    
}
void Pring(int[] mas)
{
    for (int i = 0;i<mas.Length;i++)
        Console.Write(mas[i]+" ");
    Console.WriteLine();
}
int[] SumMas(int[] m1, int[] m2)
{
    int[] mas = new int[m1.Length+m2.Length];
    int i = 0;
    foreach(var item in  m1) mas[i++] = item;
    foreach(var item in m2) mas[i++]=item;
    return mas;
}


void ReverseMas(int[] mas)
{
    Array.Reverse(mas);
}
FillArray(mas1);
Pring(mas1);
FillArray(mas2);
Pring(mas2);
int[] mas3 = SumMas(mas1, mas2);
Pring(mas3);
ReverseMas(mas3);
Pring(mas3);

Console.WriteLine($"type ={GetTypeAndMax(mas1)[0]}" + $"max={GetTypeAndMax(mas1)[1]}");
string[] GetTypeAndMax(int[]mas)
{
    string[] result = new string[2];
    result[0] = mas.GetType().ToString();
    Array.Sort(mas);
    result[1] = mas.Max().ToString();
    return result;
}
