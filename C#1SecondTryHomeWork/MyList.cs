namespace C_1SecondTryHomeWork
{
    public class MyList
    {
        private string[] _items;
        private int _count;

        // Конструктор
        public MyList()
        {
            _items = new string[5];
            _count = 0;
        }

        public int Count => _count;

        public int Capacity => _items.Length;

        // Индексатор
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Неверный индекс");

                return _items[index];
            }
        }

        // Метод добавления элемента
        public bool Add(string item)
        {
            if (_count >= _items.Length)
            {
                Console.WriteLine("Ошибка. Недостаточно выделенной памяти");
                return false;
            }

            _items[_count] = item;
            _count++;

            Console.WriteLine("Элемент добавлен");
            return true;
        }

        // Метод удаления элемента
        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                Console.WriteLine("Ошибка. Неверный индекс");
                return false;
            }

            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_count - 1] = null;
            _count--;

            Console.WriteLine("Элемент удален");
            return true;
        }

        // Изменение выделенной памяти
        public void ChangeCapacity(int newCapacity)
        {
            if (newCapacity < _count)
            {
                Console.WriteLine("Ошибка. Новая память меньше количества элементов");
                return;
            }

            string[] newItems = new string[newCapacity];

            for (int i = 0; i < _count; i++)
            {
                newItems[i] = _items[i];
            }

            _items = newItems;

            Console.WriteLine($"Выделенная память изменена на {newCapacity} элементов");
        }

        // Метод вывода элементов
        public void DisplayItems()
        {
            if (_count == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }

            Console.WriteLine("Элементы списка");

            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine($"[{i}] - {_items[i]}");
            }
        }
    }
}
