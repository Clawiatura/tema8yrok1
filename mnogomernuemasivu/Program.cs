////int[] mas1 = new int[] { 1, 2, 3 };
////int[] mas2 = new int[] { 4, 5, 6 };
////int[] mas3 = new int[] { 7, 8, 9, 10 };
////int[,,] mas4 = new int[3, 3, 4];
////for (int i = 0; i < mas1.Length; i++)
////{
////mas4[i, 0, 0] = mas1[i];
////for (int j = 0; j < mas2.Length; j++)
////{
////mas4[i, j, 0] = mas2[j];
////for (int k = 0; k < mas2.Length; k++)
////{
////mas4[i, j, k] = mas3[k];
////}
////}
////}
////for (int k = 0; k < mas4.GetLength(2); k++)
////{
////for (int i = 0; i < mas4.GetLength(0); i++)
////{
////for (int j = 0; j < mas4.GetLength(1); j++)
////{
////Console.Write(mas4[i, j, k] + " ");
////}
////Console.WriteLine();
////}
////Console.WriteLine();
////}
////Console.WriteLine("Введите число: ");
////int number = int.Parse(Console.ReadLine());
////Console.WriteLine();

////mas4[0, 2, 0] = number;
////for (int k = 0; k < mas4.GetLength(2); k++)
////{
////    for (int i = 0; i < mas4.GetLength(0); i++)
////    {
////        for (int j = 0; j < mas4.GetLength(1); j++)
////        {
////            Console.Write(mas4[i, j, k] + " ");
////        }
////        Console.WriteLine();
////    }
////    Console.WriteLine();
////} 1-й вариант решения(неправильный, наверное)


////Создайте массив из трех одномерных массивов. [3][ ]
////Заполните его значениями чисел от 1 до 10 (можно вручную, можно
////рандомом)
////Далее добавьте вывод всех значений массива.
////каждый одномерный массив выводится построчно в консоль
////Далее выведите сумму каждого одномерного массива
////*Выведите в конце среднее арифметическое всех значений массива.


////int[][] mas = new int[3][];
////mas[0] = new int[] { 1, 2, 3 };
////mas[1] = new int[] { 4, 5, 6 };
////mas[2] = new int[] { 7, 8, 9 };
////foreach (int[] i in mas)
////{
////    foreach (int x in i)
////    {
////        Console.Write(x+" ");
////    }
////    Console.WriteLine();
////}
////foreach (int[] i in mas)
////{
////    int sum = 0;
////    foreach(int x in i)
////    {
////        sum += x;      
////    }
////    Console.Write(sum + " ");
////}
////Console.WriteLine();
////foreach (int[] i in mas)
////{
////    double avg = 0;
////    foreach (int x in i)
////    {
////        avg += x;
////        avg = avg / 2;
////    }
////    Console.WriteLine(avg+ " ");
////}

//Создать числовой массив одномерных числовых массивов.
//Вручную заполнить его значениями от 1 до 10.
//Взять от пользователя число 200 и присвоить его одному из элементов
//массива.
//Вывести весь массив на консоль.

//int[][] mas = new int[3][];
//mas[0] = new int[] { 1, 2, 3 };
//mas[1] = new int[] { 4, 5, 6 };
//mas[2] = new int[] { 7, 8, 9,10 };
//Console.Write("Введите число 200: ");
//int number = int.Parse(Console.ReadLine());
//mas[0][1] = number;
//foreach (int[] i in mas)
//{
//    foreach (int x in i)
//    {
//        Console.Write(x + " ");
//    }
//    Console.WriteLine();
//}    // 2-ой вариант решения









