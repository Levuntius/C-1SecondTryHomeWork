namespace C_1SecondTryHomeWork
{
    public class MyQueue
    {
        private int[] items;
        private int head;
        private int tail;
        private int count;

        public MyQueue()
        {
            items = new int[5];
            head = 0;
            tail = 0;
            count = 0;
        }

        public void Enqueue(int value)
        {
            if (count == items.Length)
                Resize();

            items[tail] = value;
            tail = (tail + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Очередь пустая");

            int val = items[head];
            items[head] = 0;
            head = (head + 1) % items.Length;
            count--;

            return val;
        }

        public int Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Очередь пустая");

            return items[head];
        }

        public void Clear()
        {
            items = new int[5];
            head = 0;
            tail = 0;
            count = 0;
        }

        public int GetCount() => count;

        private void Resize()
        {
            int[] newArr = new int[items.Length * 2 + 1];

            for (int i = 0; i < count; i++)
            {
                newArr[i] = items[(head + i) % items.Length];
            }

            items = newArr;
            head = 0;
            tail = count;
        }
    }
}
