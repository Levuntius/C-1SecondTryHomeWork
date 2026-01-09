namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] array = new int[size];
            Random rand = new Random();

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(0, 51);
                Console.Write(array[i] + " ");
            }

            // Сортировка пузырьком
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            // Вывод отсортированного массива
            Console.WriteLine("\n\nОтсортированный массив (по убыванию):");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
