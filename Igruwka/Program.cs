using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

Random random = new Random();
int hpRogue = random.Next(30, 100);
int attackWarrior = 0;
int attackHunter = 0;
int attackMage = random.Next(15, 30);
int hpWarrior = 100;
int hpHunter = 90;
int hpMage = 70;
int attackRogue = 0;
if (hpRogue >= 50)
{
     attackRogue = random.Next(5,10);
}
else  if (hpRogue < 50)
{
     attackRogue = random.Next(3, 7);
}
Console.Write("Вам нужно выбрать класс: \n Воин \n Охотник \n Маг \n");
string userHero = Console.ReadLine();
if (userHero == "Воин")
{
    Console.Write("Выберете ваше оружие: \n Меч \n Топор\n");
    string weaponWarrior = Console.ReadLine();
    if (weaponWarrior == "Меч")
    {
        attackWarrior = random.Next(7, 12);
    }
    else if (weaponWarrior == "Топор")
    {
        attackWarrior = random.Next(10, 15);
    }    
}    
else if (userHero == "Охотник")
{
    Console.Write("Выберете ваше оружие: \n лук \n арбалет\n");
    string weaponHunter = Console.ReadLine();
    if (weaponHunter == "лук")
    {
        attackHunter = random.Next(9, 12);
    }
    else if (weaponHunter == "арбалет")
    {
        attackHunter = random.Next(12, 17);
    }
}
Console.Clear();
char[,] arena = new char[3, 3];
for (int i = 0; i < arena.GetLength(0); i++)
{
    for (int j = 0; j < arena.GetLength(1); j++)
    {

        arena[i, j] = 'm';
        arena[0, 0] = 'r';
        arena[0, 1] = 'r';
        arena[1, 1] = 'r';
        arena[2, 2] = 'r';

        Console.Write(arena[i, j] + " ");

    }
    Console.WriteLine();
}
int wins = 0;
int mode = 0;
int lvl =0;

Console.WriteLine("Вам нужно одержать 1 победу на арене, для выбора соперника введите символ: ");
char numberUsser = char.Parse(Console.ReadLine());


    if (userHero == "Воин")
    {
        if (numberUsser == 'm')
        {
            Console.WriteLine("Ваш соперник - маг, удачи в бою!");
            while (hpWarrior > attackMage && hpMage > attackWarrior)
            {
                hpWarrior -= attackMage;
                hpMage -= attackWarrior;
            }

            if (hpWarrior == attackMage)
            {
                Console.WriteLine("Маг победил воина! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Воин победил мага!"); wins++;
            }
        }
    }
    if (userHero == "Охотник")
    {
        if (numberUsser == 'm')
        {
            Console.WriteLine("Ваш соперник - маг, удачи в бою!");
            while (hpHunter > attackMage && hpMage > attackHunter)
            {
                hpHunter -= attackMage;
                hpMage -= attackHunter;
            }

            if (hpHunter == attackMage)
            {
                Console.WriteLine("Маг победил охотника! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Охотник победил мага!");
            }
        }
    }
    if (userHero == "Маг")
    {
        if (numberUsser == 'm')
        {
            Console.WriteLine("Ваш соперник - маг, удачи в бою!");
            while (hpMage > attackMage && hpMage > attackMage)
            {
                hpMage -= attackMage;
                hpMage -= attackMage;
            }

            if (hpMage == attackMage)
            {
                Console.WriteLine("Маг победил вашего мага! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Ваш маг победил мага!");
            }
        }
    }
    if (userHero == "Воин")
    {
        if (numberUsser == 'r')
        {
            Console.WriteLine("Ваш соперник - разбойник, удачи в бою!");
            while (hpWarrior > attackRogue && hpRogue > attackWarrior)
            {
                hpWarrior -= attackRogue;
                hpRogue -= attackWarrior;
            }

            if (hpWarrior == attackRogue)
            {
                Console.WriteLine("Разбойник победил воина! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Воин победил разбойника!"); wins++; mode++; lvl++;
            }
        }
    }
    if (userHero == "Охотник")
    {
        if (numberUsser == 'r')
        {
            Console.WriteLine("Ваш соперник - разбойник, удачи в бою!");
            while (hpHunter > attackRogue && hpRogue > attackHunter)
            {
                hpHunter -= attackRogue;
                hpRogue -= attackHunter;
            }

            if (hpHunter == attackRogue)
            {
                Console.WriteLine("Разбойник победил охотника! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Охотник победил разбойника!"); wins++; mode++; lvl++;
            }
        }
    }
    if (userHero == "Маг")
    {
        if (numberUsser == 'r')
        {
            Console.WriteLine("Ваш соперник - разбойник, удачи в бою!");
            while (hpMage > attackRogue && hpRogue > attackMage)
            {
                hpMage -= attackRogue;
                hpRogue -= attackMage;
            }

            if (hpMage == attackRogue)
            {
                Console.WriteLine("Разбойник победил вашего мага! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Ваш маг победил разбойника!"); wins++; mode++; lvl++;
            }
        }
    }

int hpBoss = 160;
int attackBoss = random.Next(10, 35);

if (lvl == 2 && mode == 2)

Console.Write("Вам нужно победить босса: ");
char[,] person = new char[5,5]
        {
            
            { ' ', '*', ' ', '*', ' ' },
            { '*', '*', '*', '*', '*' },
            { ' ', '*', '*', '*', ' ' },
            { ' ', ' ', '*', ' ', ' ' },
            { ' ', '*', ' ', '*', ' ' }
        };

if (userHero == "Воин")
{


    while (hpWarrior > attackBoss && hpBoss > attackWarrior)
    {
        hpWarrior -= attackBoss;
        hpBoss -= attackWarrior;
    }

    if (hpWarrior == attackMage)
    {
        Console.WriteLine("Босс победил воина! Вы проиграли! ");
    }
    else
    {
        Console.WriteLine("Воин победил Босса! "); wins++;
        

        char[,] fallenPerson = new char[5, 5]
        {
            { ' ', '*', ' ', '*', ' ' },
            { '*', ' ', '*', ' ', '*' },
            { ' ', '*', '*', '*', ' ' },
            { ' ', ' ', '*', ' ', ' ' },
            { ' ', '*', ' ', '*', ' ' }
        };

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(fallenPerson[i, j]);
            }
            Console.WriteLine();

        }
    }
    
    if (userHero == "Охотник")
    {


        while (hpHunter > attackBoss && hpBoss > attackHunter)
        {
            hpHunter -= attackBoss;
            hpBoss -= attackHunter;
        }

        if (hpWarrior == attackMage)
        {
            Console.WriteLine("Босс победил Охотника! Вы проиграли! ");
        }
        else
        {
            Console.WriteLine("Охотник победил Босса!"); wins++;
            char[,] fallenPerson = new char[5, 5]
        {
            { ' ', '*', ' ', '*', ' ' },
            { '*', ' ', '*', ' ', '*' },
            { ' ', '*', '*', '*', ' ' },
            { ' ', ' ', '*', ' ', ' ' },
            { ' ', '*', ' ', '*', ' ' } 
            
        };
            

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(fallenPerson[i, j]);
                }
                Console.WriteLine();
            }

        }

        if (userHero == "Маг")
        {
            while (hpMage > attackBoss && hpBoss > attackMage)
            {
                hpMage -= attackBoss;
                hpBoss -= attackMage;
            }

            if (hpMage == attackMage)
            {
                Console.WriteLine("Босс победил мага! Вы проиграли! ");
            }
            else
            {
                Console.WriteLine("Маг победил Босса!"); wins++;
                char[,] fallenPerson = new char[5, 5]
        {
            { ' ', '*', ' ', '*', ' ' },
            { '*', ' ', '*', ' ', '*' },
            { ' ', '*', '*', '*', ' ' },
            { ' ', ' ', '*', ' ', ' ' },
            { ' ', '*', ' ', '*', ' ' }
        };

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(fallenPerson[i, j]);
                    }
                    Console.WriteLine();
                }

            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(person[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}

