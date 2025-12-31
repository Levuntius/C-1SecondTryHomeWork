namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int task = 1
            Console.WriteLine("Enter task number (1-3)");
            Console.ReadLine();

            if task == 1
            {
                int[] array = new int[10];
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(7, 15);
                    if (array[i] > 10)
                    {
                        array[i] -= 10;
                    }
                    Console.Write(array[i] + " ");
                }
            }
            else if (task == 2)
            {
                int[] array1 = new int[10];
                int[] array2 = new int[10];
                int[] array3 = new int[10];
                Random rand = new Random();

                for (int i = 0; i < 10; i++)
                {
                    array1[i] = rand.Next(10, 31);
                    array2[i] = rand.Next(10, 31);
                    array3[i] = array1[i] + array2[i];
                }

                int sum = array3.Sum();
                double average = array3.Average();
                int max = array3.Max();
                int min = array3.Min();

                Console.WriteLine("Среднее: " + average);
                Console.WriteLine("Максимум: " + max);
                Console.WriteLine("Минимум: " + min);
            }
            else if (task == 3)
            {
                int[] array = new int[10];
                Random rand = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 51);
                }

                Console.WriteLine("Исходный массив:");
                Console.WriteLine(string.Join(" ", array));

                Array.Sort(array);
                Array.Reverse(array);

                Console.WriteLine("Отсортированный по убыванию:");
                Console.WriteLine(string.Join(" ", array));
            }
            else
            {
                Console.WriteLine("Invalid task number");
            }

            
            }

        }
    }
}
