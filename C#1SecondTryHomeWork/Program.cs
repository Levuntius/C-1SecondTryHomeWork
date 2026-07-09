using ListApp;
using System.Text;
using System.Collections.Generic;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ListApp.MyList myList = new ListApp.MyList();
            bool running = true;

            while (running)
            {
                // Вывод строго заданного текстового меню
                Console.WriteLine("\nНапишите:\n1 если хотите добавить новый елемент в список\n2 если хотите удалить елемент из списка\n3 если показать елементы списка \n4 если хотите узнать макс размер максимальный списка\n5 если хотите изменить максимальный размер списка");

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
                            Console.WriteLine("Ошибка: Введите корректное число.");
                        }
                        break;

                    case "3":
                        myList.DisplayItems();
                        Console.WriteLine($"Всего элементов в списке на данный момент: {myList.Count}");
                        break;

                    case "4":
                        Console.WriteLine($"Максимальный размер списка: {myList.MaxSize}");
                        break;

                    case "5":
                        bool sizeUpdated = false;
                        while (!sizeUpdated)
                        {
                            Console.Write("Введите цифру которая будет макс размером списка: ");
                            if (int.TryParse(Console.ReadLine(), out int newSize))
                            {
                                if (newSize < myList.Count)
                                {
                                    Console.WriteLine($"Ошибка: Новый размер ({newSize}) меньше, чем текущее количество элементов в списке ({myList.Count}). Пожалуйста, попробуйте еще раз.");
                                }
                                else
                                {
                                    myList.ChangeMaxSize(newSize);
                                    sizeUpdated = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Введите корректное число.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Неверный ввод. Пожалуйста, выберите пункт от 1 до 5.");
                        break;
                }
            }
        }
    }
}


namespace ListApp
{
    // Класс для управления списком строк
    public class MyList
    {
        private List<string> _items;
        private int _maxSize;

        // Конструктор инициализирует список и задает начальный макс. размер (5)
        public MyList()
        {
            _items = new List<string>();
            _maxSize = 5;
        }

        // Свойство для получения текущего количества элементов
        public int Count => _items.Count;

        // Свойство для получения максимального размера
        public int MaxSize => _maxSize;

        // Метод добавления элемента
        public bool Add(string item)
        {
            if (_items.Count >= _maxSize)
            {
                Console.WriteLine("Ошибка: Список заполнен! Невозможно добавить элемент.");
                return false;
            }
            _items.Add(item);
            Console.WriteLine($"Элемент \"{item}\" успешно добавлен.");
            return true;
        }

        // Метод удаления элемента по индексу
        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                string removedItem = _items[index];
                _items.RemoveAt(index);
                Console.WriteLine($"Элемент \"{removedItem}\" удален из списка.");
                return true;
            }

            Console.WriteLine("Ошибка: Неверный индекс элемента.");
            return false;
        }

        // Метод изменения максимального размера списка
        public void ChangeMaxSize(int newSize)
        {
            _maxSize = newSize;
            Console.WriteLine($"Максимальный размер списка успешно изменен на {newSize}.");
        }

        // Метод для вывода всех элементов
        public void DisplayItems()
        {
            if (_items.Count == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }

            Console.WriteLine("Элементы списка:");
            for (int i = 0; i < _items.Count; i++)
            {
                Console.WriteLine($"[{i}] - {_items[i]}");
            }
        }
    }
}
