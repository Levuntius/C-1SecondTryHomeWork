namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int rows = 3, columns = 5;
            int[,] matrix = new int[rows, columns];

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Random.Shared.Next(10, 21);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[1, j];
                sum += matrix[2, j];
            }

            Console.WriteLine("Сумма 2 и 3 строка: " + sum);
        }
    }
}
