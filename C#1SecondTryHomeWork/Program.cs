using System;
using System.Text;

namespace MemoryGame2D
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int size = 6;
            char[,] field = new char[size, size];
            bool[,] opened = new bool[size, size];

            // 18 пар (36 карт)
            char[] cards = new char[36];
            int idx = 0;

            for (char c = 'A'; c < 'A' + 18; c++)
            {
                cards[idx++] = c;
                cards[idx++] = c;
            }

            Shuffle(cards);

            // Заполняем поле
            int index = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    field[i, j] = cards[index++];

            int pairsFound = 0;
            int totalPairs = (size * size) / 2;

            while (true)
            {
                Console.Clear();
                PrintField(field, opened);

                Console.WriteLine($"Найдено пар: {pairsFound}/{totalPairs}");
                Console.WriteLine("Пожалуйста, введите две цифры с пробелом между ними для получения координат");

                Console.Write("Введите координаты первой карты (x y) или 0 для выхода: ");

                if (!ReadCoords(out int x1, out int y1, size))
                    continue;

                if (x1 == -1) return;

                if (opened[x1, y1])
                {
                    Console.WriteLine("Эта карта уже открыта");
                    Console.ReadLine();
                    continue;
                }

                opened[x1, y1] = true;
                Console.Clear();
                PrintField(field, opened);

                Console.WriteLine("Пожалуйста, введите две цифры с пробелом между ними для получения координат");
                Console.Write("Введите координаты второй карты (x y): ");

                if (!ReadCoords(out int x2, out int y2, size))
                {
                    opened[x1, y1] = false;
                    continue;
                }

                if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("Нельзя выбрать ту же карту");
                    opened[x1, y1] = false;
                    Console.ReadLine();
                    continue;
                }

                if (opened[x2, y2])
                {
                    Console.WriteLine("Эта карта уже открыта");
                    opened[x1, y1] = false;
                    Console.ReadLine();
                    continue;
                }

                opened[x2, y2] = true;

                Console.Clear();
                PrintField(field, opened);

                if (field[x1, y1] == field[x2, y2])
                {
                    Console.WriteLine("Пара найдена");
                    pairsFound++;

                    if (pairsFound == totalPairs)
                    {
                        Console.WriteLine("Вы нашли все пары!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Это не пара");
                    opened[x1, y1] = false;
                    opened[x2, y2] = false;
                }

                Console.WriteLine("Нажмите Enter");
                Console.ReadLine();
            }
        }

        // Перемешивание массива
        static void Shuffle(char[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length * 4; i++)
            {
                int a = rnd.Next(arr.Length);
                int b = rnd.Next(arr.Length);
                (arr[a], arr[b]) = (arr[b], arr[a]);
            }
        }

        // Печать поля
        static void PrintField(char[,] field, bool[,] opened)
        {
            int size = field.GetLength(0);

            Console.Write("   ");
            for (int i = 0; i < size; i++)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("  ---------------------");

            for (int i = 0; i < size; i++)
            {
                Console.Write(i + " | ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(opened[i, j] ? field[i, j] + " " : "? ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        // Чтение координат с проверкой цифры от 0 до 5
        static bool ReadCoords(out int x, out int y, int size)
        {
            x = y = -1;

            string input = Console.ReadLine();
            input = input.Trim();

            if (input == "0")
            {
                x = -1;
                return false;
            }

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                Console.WriteLine("Ошибка Введите две цифры через пробел");
                return false;
            }

            if (!int.TryParse(parts[0], out x) || !int.TryParse(parts[1], out y))
            {
                Console.WriteLine("Ошибка Нужно вводить только цифры");
                return false;
            }

            if (x < 0 || x >= size || y < 0 || y >= size)
            {
                Console.WriteLine("Ошибка Введите цифры от 0 до 5");
                return false;
            }

            return true;
        }
    }
}
