namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = Random.Shared.Next(51);

            }
            Console.WriteLine(string.Join(", ", arr));

            bool swapped = true;
            int start = 0;
            int end = arr.Length - 1;

            while (swapped)
            {
                swapped = false;

                // Проход слева направо
                for (int i = start; i < end; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;
                end--;

                // Проход справа налево
                for (int i = end; i > start; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                        swapped = true;
                    }
                }

                start++;
            }
            Console.WriteLine(string.Join(", ", arr));



        }
    }
}
