using System;
using System.Text;
using System.Text.RegularExpressions;

namespace MemoryGame2D
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            (int width, int height) = ReadFieldSize();
            int total = width * height;
            int pairs = total / 2;

            char[] cards = GenerateCards(pairs);
            ShuffleCards(cards);

            (char letter, bool opened)[,] field = InitializeField(width, height, cards);

            int found = 0;

            while (true)
            {
                Console.Clear();
                PrintField(field, width, height);
                Console.WriteLine($"Найдено пар: {found}/{pairs}");

                var (x1, y1) = ReadCoords(width, height);
                if (x1 == -1) return;

                if (field[x1, y1].opened) continue;

                field[x1, y1].opened = true;

                Console.Clear();
                PrintField(field, width, height);

                var (x2, y2) = ReadCoords(width, height);
                if (x2 == -1) return;

                if (x1 == x2 && y1 == y2)
                {
                    field[x1, y1].opened = false;
                    continue;
                }

                if (field[x2, y2].opened)
                {
                    field[x1, y1].opened = false;
                    continue;
                }

                field[x2, y2].opened = true;

                Console.Clear();
                PrintField(field, width, height);

                if (field[x1, y1].letter == field[x2, y2].letter)
                {
                    found++;
                    if (found == pairs)
                    {
                        Console.WriteLine("Поздравляем! Все пары найдены");
                        return;
                    }
                }
                else
                {
                    field[x1, y1].opened = false;
                    field[x2, y2].opened = false;
                }

                Console.WriteLine("Нажмите Enter");
                Console.ReadLine();
            }
        }

        static (int width, int height) ReadFieldSize()
        {
            while (true)
            {
                Console.Write("Введите ширину и высоту поля (например 6 6): ");
                string input = Console.ReadLine();

                var m = Regex.Match(input, @"^\s*([1-9])[ _-]([1-9])\s*$");
                if (!m.Success) continue;

                int w = int.Parse(m.Groups[1].Value);
                int h = int.Parse(m.Groups[2].Value);

                if ((w * h) % 2 == 0)
                    return (w, h);

                Console.WriteLine("Количество должно делиться на 2");
            }
        }

        static char[] GenerateCards(int pairs)
        {
            char[] arr = new char[pairs * 2];
            int idx = 0;

            for (char c = 'A'; idx < arr.Length; c++)
            {
                arr[idx++] = c;
                arr[idx++] = c;
            }

            return arr;
        }

        static void ShuffleCards(char[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length * 4; i++)
            {
                int a = rnd.Next(arr.Length);
                int b = rnd.Next(arr.Length);
                (arr[a], arr[b]) = (arr[b], arr[a]);
            }
        }

        static (char letter, bool opened)[,] InitializeField(int width, int height, char[] cards)
        {
            var field = new (char, bool)[width, height];
            int idx = 0;

            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    field[i, j] = (cards[idx++], false);

            return field;
        }

        static void PrintField((char letter, bool opened)[,] field, int width, int height)
        {
            Console.Write("   ");
            for (int i = 0; i < height; i++)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("  " + new string('-', height * 2));

            for (int i = 0; i < width; i++)
            {
                Console.Write(i + " | ");
                for (int j = 0; j < height; j++)
                    Console.Write(field[i, j].opened ? field[i, j].letter + " " : "? ");
                Console.WriteLine();
            }
        }

        static (int x, int y) ReadCoords(int width, int height)
        {
            while (true)
            {
                Console.Write("Введите координаты вот так (x_y) или нажмите Escape для выхода: ");

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Escape)
                        return (-1, -1);
                }

                string input = Console.ReadLine();

                string pattern = $@"^\s*([0-{width - 1}])[ _-]([0-{height - 1}])\s*$";
                var m = Regex.Match(input, pattern);

                if (!m.Success)
                {
                    Console.WriteLine("Неверний ввод");
                    continue;
                }

                int x = int.Parse(m.Groups[1].Value);
                int y = int.Parse(m.Groups[2].Value);

                Console.WriteLine($"{x} {y}");
                return (x, y);
            }
        }
    }
}

