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
            if (tail == items.Length)
            {
                int[] newArr = new int[items.Length * 2 + 1];
                for (int i = 0; i < items.Length; i++)
                {
                    newArr[i] = items[i];
                }
                items = newArr;
            }

            items[tail] = value;
            tail++;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Очередь пустая");
            }

            int val = items[head];
            items[head] = 0;
            head++;
            count--;

            return val;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Очередь пустая");
            }

            return items[head];
        }

        public void Clear()
        {
            items = new int[5];
            head = 0;
            tail = 0;
            count = 0;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
