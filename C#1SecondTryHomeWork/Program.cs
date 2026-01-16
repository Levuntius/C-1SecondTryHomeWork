using System.ComponentModel.Design;
using System.Text;
using System.Xml.Linq;

namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int task = 1;
            //создание и заполнение массива
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random.Shared.Next(51);

            }


            if (task == 2)
            {
                
                int save = 0;
                int min = 0;
                bool anyChanges = false;

                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        // находит индекс минимального элемента в неотсортированом массиве
                        int minIndex = i;
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[j] < array[minIndex])
                            {
                                minIndex = j;
                            }
                        }

                        // неняет текущийе элементы местами
                        save = array[i];
                        array[i] = array[minIndex];
                        array[minIndex] = save;
                    }
                
                Console.WriteLine($"Массив: {string.Join(", ", array)}");
            }

            else
            {
                // максимальное число в массиве
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }

                // массив счетчиков чисел
                int[] count = new int[max + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    count[array[i]]++;
                }

                // перезаписываем исходный массив отсортированными числами
                int index = 0;
                for (int i = 0; i < count.Length; i++)
                {
                    while (count[i] > 0)
                    {
                        array[index] = i;
                        index++;
                        count[i]--;
                    }
                }

                Console.WriteLine($"Массив: {string.Join(", ", array)}");











            }




        }
    }
}
