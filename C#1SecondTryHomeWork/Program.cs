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

            int size = 8;
            char[,] field = new char[size, size];
            bool[,] opened = new bool[size, size];

            // 32 пары (64 клетки)
            char[] cards = new char[64];
            int idx = 0;

            for (char c = 'A'; c <= 'Z'; c++)
            {
                cards[idx++] = c;
                cards[idx++] = c;
                if (idx >= 64) break;
            }

            // Если букв не хватило — добавим пары символов
            char extra = 'a';
            while (idx < 64)
            {
                cards[idx++] = extra;
                cards[idx++] = extra;
                extra++;
            }

            Shuffle(cards);

            // Заполняем поле
            int index = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    field[i, j] = cards[index++];

            int pairsFound = 0;
            int totalPairs = (size * size) / 2; // 64 / 2 = 32 пары

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

                if (!ReadCoords(out int x2, out