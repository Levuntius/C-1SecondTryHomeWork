using System;
using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;

            int[,] field = new int[3, 3];

            int currentPlayer = 1; // 1 = X, 2 = O
            int moves = 0;

            while (true)
            {
                Console.Clear();
                PrintField(field);

                Console.WriteLine(
                    currentPlayer == 1
                    ? "Ход игрока X"
                    : "Ход игрока O");

                var (x, y) = ReadCoords();

                // клетка занята
                if (field[x, y] != 0)
                {
                    Console.WriteLine("Клетка занята!");
                    Console.ReadLine();
                    continue;
                }

                field[x, y] = currentPlayer;
                moves++;

                if (CheckWin(field, currentPlayer))
                {
                    Console.Clear();
                    PrintField(field);

                    Console.WriteLine(
                        currentPlayer == 1
                        ? "Победил игрок X!"
                        : "Победил игрок O!");

                    break;
                }

                if (moves == 9)
                {
                    Console.Clear();
                    PrintField(field);
                    Console.WriteLine("Ничья!");
                    break;
                }

                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }

            Console.ReadLine();
        }

        static void PrintField(int[,] field)
        {
            Console.WriteLine("   0 1 2");
            Console.WriteLine("  -------");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " | ");

                for (int j = 0; j < 3; j++)
                {
                    char symbol = '?';

                    if (field[i, j] == 1)
                        symbol = 'X';
                    else if (field[i, j] == 2)
                        symbol = 'O';

                    Console.Write(symbol + " ");
                }

                Console.WriteLine();
            }
        }

        static (int x, int y) ReadCoords()
        {
            while (true)
            {
                Console.Write("Введите координаты (x y): ");

                string input = Console.ReadLine();

                string[] parts = input.Split(' ');

                if (parts.Length != 2)
                {
                    Console.WriteLine("Введите две координаты!");
                    continue;
                }

                bool okX = int.TryParse(parts[0], out int x);
                bool okY = int.TryParse(parts[1], out int y);

                if (!okX || !okY)
                {
                    Console.WriteLine("Введите числа!");
                    continue;
                }

                if (x < 0 || x > 2 || y < 0 || y > 2)
                {
                    Console.WriteLine("Допустимы только числа от 0 до 2!");
                    continue;
                }

                return (x, y);
            }
        }

        static bool CheckWin(int[,] field, int player)
        {
            // строки
            for (int i = 0; i < 3; i++)
            {
                if (field[i, 0] == player &&
                    field[i, 1] == player &&
                    field[i, 2] == player)
                    return true;
            }

            // столбцы
            for (int j = 0; j < 3; j++)
            {
                if (field[0, j] == player &&
                    field[1, j] == player &&
                    field[2, j] == player)
                    return true;
            }

            // главная диагональ
            if (field[0, 0] == player &&
                field[1, 1] == player &&
                field[2, 2] == player)
                return true;

            // побочная диагональ
            if (field[0, 2] == player &&
                field[1, 1] == player &&
                field[2, 0] == player)
                return true;

            return false;
        }
    }
}
