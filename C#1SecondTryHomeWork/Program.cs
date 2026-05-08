using System;
using System.Text;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            (char letter, int position)[] cards =
            {
                ('A', 0), ('A', 1),
                ('B', 2), ('B', 3),
                ('C', 4), ('C', 5),
                ('D', 6), ('D', 7),
                ('E', 8), ('E', 9),
                ('F', 10), ('F', 11),
                ('G', 12), ('G', 13),
                ('H', 14), ('H', 15)
            };

            Random random = new Random();

            for (int i = 0; i < cards.Length * 4; i++)
            {
                int index1 = random.Next(0, cards.Length);
                int index2 = random.Next(0, cards.Length);

                var temp = cards[index1];
                cards[index1] = cards[index2];
                cards[index2] = temp;
            }

            while (true)
            {
                int firstIndex;

                while (true)
                {
                    Console.Write("Первая карта 1-16 или 0 для выхода: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out firstIndex))
                    {
                        if (firstIndex == 0)
                            return;

                        if (firstIndex >= 1 && firstIndex <= 16)
                            break;
                    }

                    Console.WriteLine("Ошыбка! Введите число 1-16");
                }

                firstIndex--;

                Console.WriteLine($"Первая карта: {cards[firstIndex].letter}");

                int secondIndex;

                while (true)
                {
                    Console.Write("Вторая карта 1-16: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out secondIndex))
                    {
                        if (secondIndex >= 1 && secondIndex <= 16)
                        {
                            secondIndex--;

                            if (secondIndex == firstIndex)
                            {
                                Console.WriteLine("Нельзя выбрать ту же карту");
                                continue;
                            }

                            break;
                        }
                    }

                    Console.WriteLine("Ошыбка! Введите число 1-16");
                }

                Console.WriteLine($"Вторая карта: {cards[secondIndex].letter}");

                if (cards[firstIndex].letter == cards[secondIndex].letter)
                {
                    Console.WriteLine("Пара найдена");
                }
                else
                {
                    Console.WriteLine("Это не пара");
                }

                Console.WriteLine();
                Console.WriteLine("Нажмите Enter для следующего хода");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}


