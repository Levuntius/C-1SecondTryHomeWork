public class MyLinkedList<T>
{
    private Node<T>? head;   // первый элемент списка
    private Node<T>? tail;   // последний элемент списка
    private int count;       // количество элементов

    // Внутренний класс узла
    private class Node<T>
    {
        public T Value;
        public Node<T>? Next;

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
            // список пуст — head и tail указывают на новый узел
            head = newNode;
            tail = newNode;
        }
        else
        {
            if (tail == null)
            {
                Node<T> current = head;
                while (current.Next != null)
                    current = current.Next;

                tail = current;
            }

            tail.Next = new
