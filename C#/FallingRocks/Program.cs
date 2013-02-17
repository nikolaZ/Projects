using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;



struct RocksPattern
{
    public static string[] Type = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
    public static ConsoleColor[] Colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan,
                                                ConsoleColor.Green, ConsoleColor.Magenta };
}
struct Object
{
    public int x;
    public int y;
    public ConsoleColor color;
    public string d;
}
struct Rocks
{
    public int x;
    public int y;
    public ConsoleColor color;
    public string r;
}

class fallingRocks
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintInfo(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void Main()
    {
        int playground = 11;
        byte life = 3;

        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;
        Object dwarf = new Object();
        dwarf.x = 4;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.color = ConsoleColor.White;
        dwarf.d = "(0)";
        Random generator = new Random();
        List<Rocks> rocks = new List<Rocks>();


        List<string> typer = new List<string> { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        Random typer_rand = new Random();
        int index = typer_rand.Next(0, 10);
        string value = typer[index];
        List<ConsoleColor> color = new List<ConsoleColor> {ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Cyan,
                                                ConsoleColor.Green, ConsoleColor.Magenta };
        Random color_rand = new Random();
        int indexColor = typer_rand.Next(0, 4);
        ConsoleColor rockColor = color[indexColor];


        while (true)
        {
            bool hit = false;
            {
                Rocks newRock = new Rocks();
                newRock.color = rockColor;
                newRock.x = generator.Next(0, playground);
                newRock.y = 0;
                newRock.r = value;
                rocks.Add(newRock);
            }
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey();//clear other buttons for smooth moving(not neccessary)
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playground)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }
            List<Rocks> newList = new List<Rocks>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rocks oldRock = rocks[i];
                Rocks newRock = new Rocks();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.r = oldRock.r;
                newRock.color = oldRock.color;
                if (newRock.y == dwarf.y && newRock.x == dwarf.x)
                {
                    life--;
                    hit = true;
                    if (life <= 0)
                    {
                        PrintInfo(20, 8, "WASTED", ConsoleColor.DarkRed);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            Console.Clear();
            foreach (Rocks rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.r, rock.color);
            }
            if (hit)
            {
                PrintOnPosition(dwarf.x, dwarf.y, "XXX", ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.d, dwarf.color);
            }
            PrintInfo(15, 5, "Lifes: " + life, ConsoleColor.White);
            PrintInfo(15, 5, "Lifes: " + life, ConsoleColor.White);
            Thread.Sleep(150);
        }

    }
}


