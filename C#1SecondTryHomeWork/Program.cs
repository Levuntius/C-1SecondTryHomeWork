namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int rows = 3, cols = 5;
            int[,] matrix = new int[rows, cols];

            // заполнение
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(10, 21);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[1, j]; // 2 строка
                sum += matrix[2, j]; // 3 строка
            }

            Console.WriteLine("Сумма 2 и 3 строки: " + sum);
        }
    }
}
