namespace C_1SecondTryHomeWork
{
    public class MyQueue
    {
        private int[] items;
        private int _head;
        private int _tail;
        private int _count;
        internal int startItems = 5;    

        public MyQueue()
        {
            items = new int[startItems];
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public void Enqueue(int value)
        {
            if (count == items.Length)
                Resize();

            items[_tail] = value;
            _tail = (_tail + 1) % items.Length;
            _count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Очередь пустая");

            int val = items[_head];
            items[_head] = 0;
            _head = (_head + 1) % items.Length;
            _count--;

            return val;
        }

        public int Peek()
        {
            if (_count == 0)
                throw new InvalidOperationException("Очередь пустая");

            return items[_head];
        }

        public void Clear()
        {
            items = new int[startItems];
            _head = 0;
            _tail = 0;
            _count = 0;
        }

        public int GetCount() => _count;

        private void Resize()
        {
            int[] newArr = new int[items.Length * 2 + 1];

            for (int i = 0; i < _count; i++)
            {
                newArr[i] = items[(_head + i) % items.Length];
            }

            items = newArr;
            _head = 0;
            _tail = _count;
        }
    }
}
