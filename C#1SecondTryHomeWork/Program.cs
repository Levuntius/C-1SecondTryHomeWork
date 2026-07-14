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

            MyList myList = new MyList();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Напишите:");
                Console.WriteLine("1 если хотите добавить новый элемент в список");
                Console.WriteLine("2 если хотите удалить элемент из списка");
                Console.WriteLine("3 если хотите показать элементы списка");
                Console.WriteLine("4 если хотите узнать, сколько памяти выделено");
                Console.WriteLine("5 если хотите изменить выделенную память");
                Console.WriteLine("0 если хотите выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите строку для добавления: ");
                        string textToAdd = Console.ReadLine();
                        myList.Add(textToAdd);
                        break;

                    case "2":
                        Console.Write("Введите индекс элемента для удаления: ");

                        if (int.TryParse(Console.ReadLine(), out int indexToRemove))
                        {
                            myList.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: Введите корректное число");
                        }

                        break;

                    case "3":
                        myList.DisplayItems();
                        Console.WriteLine($"Всего элементов в списке: {myList.Count}");
                        break;

                    case "4":
                        Console.WriteLine($"Выделено памяти под {myList.Capacity} элементов");
                        break;

                    case "5":
                        bool sizeUpdated = false;

                        while (!sizeUpdated)
                        {
                            Console.Write("Введите новый размер памяти: ");

                            if (int.TryParse(Console.ReadLine(), out int newSize))
                            {
                                if (newSize < myList.Count)
                                {
                                    Console.WriteLine($"Ошибка. Новый размер ({newSize}) меньше количества элементов ({myList.Count})");
                                }
                                else
                                {
                                    myList.ChangeCapacity(newSize);
                                    sizeUpdated = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка. Введите корректное число");
                            }
                        }

                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Неверный ввод. Выберите пункт от 0 до 5");
                        break;
                }
            }
        }
    }
}