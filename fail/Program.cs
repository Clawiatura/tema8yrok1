//Напишите программу, которая позволяет пользователю перемещаться по
//файловой системе компьютера.
//На экране должна быть видна текущая директория пользователя и под
//этим выводом ожидаться название папки, в которую необходимо перейти.
//После ввода, пользователь переходит в эту папку


string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine("Текущая директория: " + currentDirectory);

while (true)
{
    Console.Write("Введите название папки, в которую необходимо перейти (или 'exit' для выхода): ");
    string folderName = Console.ReadLine();

    if (folderName.ToLower() == "exit")
    {
        break;
    }

    string newDirectory = Path.Combine(currentDirectory, folderName);

    if (Directory.Exists(newDirectory))
    {
        currentDirectory = newDirectory;
        Directory.SetCurrentDirectory(currentDirectory);
        Console.WriteLine("Текущая директория: " + currentDirectory);
    }
    else
    {
        Console.WriteLine("Папка не найдена!");
    }
}

