using System;
using System.ComponentModel.Design;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int ante;
            int num1;
            int num2;
            int num3;

            Console.WriteLine("введите размер ставки от 5$ до 100$, шаг ставки равен 5$");
            ante=int.Parse(Console.ReadLine());

            if (ante<5 || ante>100 || ante%5!=0)
            {
                Console.WriteLine("неверный размер ставки");
                return;
            }
            else
            {
                num1 = Random.Shared.Next(1, 10);
                num2 = Random.Shared.Next(1, 10);
                num3 = Random.Shared.Next(1, 10);
            }

            Console.WriteLine($"Ваша ставка {ante}$");

            if (num1 == num2 && num2 == num3)
            {
                if (num1==7)
                {
                    Console.WriteLine($"Выпало число {num1}{num2}{num3} ДЖЕКПОТ Вы выиграли {150 * 1.5 * ante}$");
                }
                Console.WriteLine($"Выпало число {num1}{num2}{num3} Вы выиграли {(num1 * 10) * 1.5 * ante}$");
            }

            else if (num1==num2 || num1==num3 || num2==num3)
            {
                if (num1 == 7 || num2 == 7 || num3 == 7)
                {
                    Console.WriteLine($"Выпало число {num1}{num2}{num3} Вы выиграли {15 * 1.25 * ante}$");
                }

                else if (num1 == num2 || num1 == num3)
                {
                    Console.WriteLine($"Выпало число {num1}{num2}{num3} Вы выиграли {num1 * 1.25 * ante}$");
                }
                
                else if (num2 == num3)
                {
                    Console.WriteLine($"Выпало число {num1}{num2}{num3} Вы выиграли {num2 * 1.25 * ante}$");
                }

            }


            else
            {
                Console.WriteLine($"Выпало число {num1}{num2}{num3} Вы проиграли $");
            }
        }
    }
}
