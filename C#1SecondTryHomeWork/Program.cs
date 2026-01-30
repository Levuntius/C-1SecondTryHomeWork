namespace C_1SecondTryHomeWork
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

              // Task 1
            /*int rows = 3, columns = 5;
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

              Console.WriteLine("Сумма 2 и 3 строка: " + sum);*/

              // Task 2
            /*int rows = 4, columns = 5;
              int[,] matrix = new int[rows, columns];

              for (int i = 0; i < rows; i++)
              {
                  for (int j = 0; j < columns; j++)
                  {
                      matrix[i, j] = Random.Shared.Next(10, 101);
                      Console.Write(matrix[i, j] + "\t");
                  }
                  Console.WriteLine();
              }

              int maxSum = int.MinValue;
              int maxRow = 0;

              for (int i = 0; i < rows; i++)
              {
                  int rowSum = 0;
                  for (int j = 0; j < columns; j++)
                      rowSum += matrix[i, j];

                  Console.WriteLine($"Сумма строки {i + 1}: {rowSum}");

                  if (rowSum > maxSum)
                  {
                      maxSum = rowSum;
                      maxRow = i;
                  }
              }

              Console.WriteLine("Максимальная сумма в строке: " + (maxRow + 1));*/
              // Task 3
              int n = 5;
              int[,] matrix = new int[n, n];

              for (int i = 0; i < n; i++)
              {
                  for (int j = 0; j < n; j++)
                  {
                      matrix[i, j] = Random.Shared.Next(-10, 11);
                      Console.Write(matrix[i, j] + "\t");
                  }
                  Console.WriteLine();
              }

              Console.WriteLine("Главная диагональ (положительные):");
              for (int i = 0; i < n; i++)
              {
                  if (matrix[i, i] > 0)
                      Console.WriteLine(matrix[i, i]);
              }

              Console.WriteLine("Побочная диагональ (положительные):");
              for (int i = 0; i < n; i++)
              {
                  if (matrix[i, n - 1 - i] > 0)
                      Console.WriteLine(matrix[i, n - 1 - i]);
              }

        }
    }
}
