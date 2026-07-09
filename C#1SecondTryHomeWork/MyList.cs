namespace C_1SecondTryHomeWork
{
    
    public class MyList
    {
        private List<string> _items;
        private int _maxSize;

        // Конструктор инициализирует список макс размер 5
        public MyList() 
        {
            _items = new List<string>();
            _maxSize = 5;
        }

        // полученить количество элементов
        public int Count => _items.Count;

        // получения максимальный размер
        public int MaxSize => _maxSize;

        // метод добавления элемента
        public bool Add(string item)
        {
            if (_items.Count >= _maxSize)
            {
                Console.WriteLine("Список заполнен! Невозможно добавить элемент");
                return false;
            }
            _items.Add(item);
            Console.WriteLine($"Элемент добавлен");
            return true;
        }

        // метод удаления элемента по индексу
        public bool RemoveAt(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                string removedItem = _items[index];
                _items.RemoveAt(index);
                Console.WriteLine($"Элемент удален из списка.");
                return true;
            }

            Console.WriteLine("Ошибка неверный индекс элемента.");
            return false;
        }

        // метод изменения максимального размера списка
        public void ChangeMaxSize(int newSize)
        {
            _maxSize = newSize;
            Console.WriteLine($"Максимальный размер списка успешно изменен на {newSize}.");
        }

        // метод для вывода всех элементов
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
