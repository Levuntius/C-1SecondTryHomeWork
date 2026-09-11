namespace C_1SecondTryHomeWork
{
    public class MyLinkedList<T>
    {
        private Node? head;
        private Node? tail;
        private int count;

        private class Node
        {
            public T Value;
            public Node? Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        // Количество элементов
        public int Count => count;

        // Индексатор
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                Node current = head!;
                for (int i = 0; i < index; i++)
                    current = current.Next!;

                return current.Value;
            }
            set
            {
                if (index < 0 || index >= count)
                    throw new ArgumentOutOfRangeException(nameof(index));

                Node current = head!;
                for (int i = 0; i < index; i++)
                    current = current.Next!;

                current.Value = value;
            }
        }

        // Добавить в конец
        public void AddLast(T value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }

            count++;
        }

        // Добавить в начало
        public void AddFirst(T value)
        {
            Node newNode = new Node(value);

            newNode.Next = head;
            head = newNode;

            if (tail == null)
                tail = newNode;

            count++;
        }

        // Удалить первый
        public void RemoveFirst()
        {
            if (head == null)
                throw new InvalidOperationException("Список пуст");

            head = head.Next;

            if (head == null)
                tail = null;

            count--;
        }

        // Перебор элементов
        public IEnumerable<T> AsEnumerable()
        {
            Node? current = head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        // -----------------------------
        //      Операторы сравнения
        // -----------------------------
        public static bool operator ==(MyLinkedList<T>? a, MyLinkedList<T>? b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            if (a.count != b.count)
                return false;

            Node? ca = a.head;
            Node? cb = b.head;

            while (ca != null)
            {
                if (!Equals(ca.Value, cb!.Value))
                    return false;

                ca = ca.Next;
                cb = cb.Next;
            }

            return true;
        }

        public static bool operator !=(MyLinkedList<T>? a, MyLinkedList<T>? b)
            => !(a == b);

        public override bool Equals(object? obj)
            => obj is MyLinkedList<T> other && this == other;

        public override int GetHashCode()
            => count; // простая реализация

        // -----------------------------
        //      Оператор +
        // -----------------------------
        public static MyLinkedList<T> operator +(MyLinkedList<T> a, MyLinkedList<T> b)
        {
            MyLinkedList<T> result = new MyLinkedList<T>();

            foreach (var item in a.AsEnumerable())
                result.AddLast(item);

            foreach (var item in b.AsEnumerable())
                result.AddLast(item);

            return result;
        }

        // -----------------------------
        //      Оператор -
        // -----------------------------
        public static MyLinkedList<T> operator -(MyLinkedList<T> a, MyLinkedList<T> b)
        {
            MyLinkedList<T> result = new MyLinkedList<T>();

            foreach (var item in a.AsEnumerable())
            {
                bool found = false;

                foreach (var rem in b.AsEnumerable())
                {
                    if (Equals(item, rem))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    result.AddLast(item);
            }

            return result;
        }
    }
}
