public class MyLinkedList<T>
{
    private Node<T> head;   // первый элемент списка
    private Node<T> tail;   // последний элемент списка
    private int count;      // количество элементов

    // Внутренний класс узла
    private class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    // Добавить элемент в конец
    public void AddLast(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }

        count++;
    }

    // Добавить элемент в начало
    public void AddFirst(T value)
    {
        Node<T> newNode = new Node<T>(value);

        newNode.Next = head;
        head = newNode;

        if (tail == null)
            tail = newNode;

        count++;
    }

    // Удалить первый элемент
    public void RemoveFirst()
    {
        if (head == null)
            throw new InvalidOperationException("Список пуст");

        head = head.Next;

        if (head == null)
            tail = null;

        count--;
    }

    // Проверка наличия элемента
    public bool Contains(T value)
    {
        Node<T> current = head;

        while (current != null)
        {
            if (current.Value.Equals(value))
                return true;

            current = current.Next;
        }

        return false;
    }

    // Количество элементов
    public int Count => count;

    // Перебор элементов
    public IEnumerable<T> AsEnumerable()
    {
        Node<T> current = head;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }
}
