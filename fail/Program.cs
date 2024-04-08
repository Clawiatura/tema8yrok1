using System.Text;

Console.WriteLine("Введите путь к файлу: ");
string path = Console.ReadLine();
DirectoryInfo dirInfo = new DirectoryInfo($@"{path}");
FileInfo[] file = dirInfo.GetFiles();
Console.WriteLine("Введите текст, который нужно записать в файл");
string textPath = Console.ReadLine();
using (FileStream fStream = new FileStream("file.txt", FileMode.OpenOrCreate)) // Не записывается в файл 
{
    byte[] buffer = Encoding.Default.GetBytes(textPath);
    await fStream.WriteAsync(buffer, 0, buffer.Length);
    Console.WriteLine("Запись сохранена");
}





string filePath = @"C:\DZ\file1.txt";
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("123456");
}
Console.WriteLine("Файл создан");
string filePath1 = @"C:\DZ\file2.txt";
using (StreamWriter writer = new StreamWriter(filePath1))
{
    writer.WriteLine("654321");
}
Console.WriteLine("Файл создан");



using(StreamReader reader = new StreamReader(filePath)) // В классе писали название файла в системе "file.txt, пробовал так же, ошибка выскакивала" 
{
    string text = await reader.ReadToEndAsync();
    Console.WriteLine(text);


}

using (StreamReader reader = new StreamReader(filePath1)) // В классе писали название файла в системе "file1.txt, пробовал так же, ошибка выскакивала"
{
    string text = "";
    while ((text = await reader.ReadLineAsync()) != null)
    {
        Console.WriteLine(text);
    }
}