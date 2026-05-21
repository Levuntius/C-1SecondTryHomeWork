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

            int size = 5;
            char[,] field = new char[size, size];
            bool[,] opened = new bool[size, size];

            // 12 пар + 1 лишняя карта
            char[] cards =
            {
                'A','A','B','B','C','C','D','D','E','E','F','F',
                'G','G','H','H','I','I','J','J','K','K','L','L',
                '*' // лишняя карта
            };

            Shuffle(cards);

            // Заполняем поле
            int index = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    field[i, j] = cards[index++];

            int pairsFound = 0;
            int totalPairs = (size * size - 1) / 2; // 25 клеток → 12 пар

            while (true)
            {
                Console.Clear();
                PrintField(field, opened);

                Console.WriteLine($"Найдено пар: {pairsFound}/{totalPairs}");
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
                    Console.WriteLine("Пара найдена!");
                    pairsFound++;

                    if (pairsFound == totalPairs)
                    {
                        Console.WriteLine("Поздравляем! Вы нашли все пары!");
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

            Console.WriteLine("   0 1 2 3 4");
            Console.WriteLine("  -----------");

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

        // Чтение координат с Trim, Split, RemoveEmptyEntries
        static bool ReadCoords(out int x, out int y, int size)
        {
            x = y = -1;

            string input = Console.ReadLine();

            input = input.Trim(); // удаляем пробелы в начале и конце

            if (input == "0")
            {
                x = -1;
                return false;
            }

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                Console.WriteLine("Ошибка! Введите два числа через пробел");
                return false;
            }

            if (!int.TryParse(parts[0], out x) || !int.TryParse(parts[1], out y))
            {
                Console.WriteLine("Ошибка! Введите числа");
                return false;
            }

            if (x < 0 || x >= size || y < 0 || y >= size)
            {
                Console.WriteLine("Ошибка! Координаты вне поля");
                return false;
            }

            return true;
        }
    }
}



