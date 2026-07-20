namespace C_1SecondTryHomeWork

{
    public class MyStack
    {
        private int[] items;
        private int count;

        public MyStack()
        {
            items = new int[5];
            count = 0;
        }

        public void Push(int value)
        {
            if (count == items.Length)
            {
                int[] newArray = new int[items.Length * 2+1];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }

            items[count] = value;
            count++;
        }

        public int Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
                return 0;
            }

            count--;
            int val = items[count];
            items[count] = 0;

            return val;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
                return 0;
            }

            return items[count - 1];
        }

        public void Clear()
        {
            items = new int[4];
            count = 0;
        }

        public int GetCount()
        {
            return count;
        }
    }
}

