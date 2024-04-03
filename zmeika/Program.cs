char[,] grid = new char[18, 18];
Random rand = new Random();
char[] snake = new char[4];
Array.Fill(snake, 'X');
int[,] geoSnake = new int[4, 2];
for (int i = 0; i < geoSnake.GetLength(1); i++)
{
    geoSnake[0, i] = snake.Length - i - 1;
}

char geo = 'd';
do
{
    Console.Clear();
    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            grid[i, j] = '.';

        }
        
    }
    int length = 4;
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid.Length; j++)
        {
            grid[4,7] = '*';
            grid[6, 9] = '*';
            int foodX = 4;
            int foodY = 7;
            if (geoSnake[0, 0] == foodX && geoSnake[0, 1] == foodY)
            {
                length++
                Array.Resize(ref snake, length);
                snake[length - 1] = 'X';
            }
            }
    }


    switch (geo)
    {
        case 'd':
        case 'в':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = ++geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 's':
        case 'ы':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = ++geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'a':
        case 'ф':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = --geoSnake[0, 1];
                geoSnake[0, 1] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
        case 'w':
        case 'ц':
            {
                for (int i = snake.Length - 1; i > 0; i--)
                {
                    geoSnake[i, 0] = geoSnake[i - 1, 0];
                    geoSnake[i, 1] = geoSnake[i - 1, 1];
                }
                int temp = --geoSnake[0, 0];
                geoSnake[0, 0] = temp;
                for (int i = 0; i < snake.Length; i++)
                {
                    int x = geoSnake[i, 0];
                    int y = geoSnake[i, 1];
                    grid[x, y] = 'X';
                }
            }
            break;
    }

    for (int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            Console.Write(grid[i, j] + " ");
        }
        Console.WriteLine();
    }
    if (Console.KeyAvailable)
    {
        geo = Console.ReadKey().KeyChar;
    }
    Thread.Sleep(500);
}
while (true);