//Напишите программу, которая позволяет пользователю удалить
//файл или папку. Программа должна запрашивать путь к файлу
//или папке, которую нужно удалить, и выполнить удаление. Перед
//удалением, программа должна запрашивать подтверждение
//пользователя
Console.WriteLine("Что вы хотите удалить файл или папку с файлами?");
string FileOrDir = Console.ReadLine();
if (FileOrDir == "файл" || FileOrDir == "Файл")
{
    Console.WriteLine("Введите путь к файлу: ");
    string FilePath = Console.ReadLine();

    Console.WriteLine("Вы уверены что хотите удалить?");
    string YesOrNO = Console.ReadLine();
    if (YesOrNO == "Да" || YesOrNO == "да")
    {
        File.Delete(FilePath);
        Console.WriteLine("Файл успешно удален");
    }
    else Console.WriteLine("Файл не будет удалено.");
}
else
{ Console.WriteLine("Введите путь к папке: ");
    string DirPath = Console.ReadLine();
    Console.WriteLine("Вы уверены что хотите удалить?");
    string YesOrNO = Console.ReadLine();
    if (YesOrNO == "Да" || YesOrNO == "да")
    {
        Directory.Delete(DirPath);
        Console.WriteLine("Удаленно");
    }
    else Console.WriteLine("Папка не будет удаленна.");
}
