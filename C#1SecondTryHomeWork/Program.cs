namespace C_1SecondTryHomeWork
{
    using System;

    class Program
    {
        static void Main()
        {
            // Создаём два списка
            var list1 = new MyLinkedList<int>();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);

            var list2 = new MyLinkedList<int>();
            list2.AddLast(1);
            list2.AddLast(2);
            list2.AddLast(3);

            // -----------------------------
            //     Индексатор
            // -----------------------------
            Console.WriteLine("Индексатор:");
            Console.WriteLine(list1[0]); // 1
            Console.WriteLine(list1[1]); // 2

            list1[1] = 99;
            Console.WriteLine(list1[1]); // 99

            // -----------------------------
            //     Цикл for
            // -----------------------------
            Console.WriteLine("\nЦикл for:");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }

            // -----------------------------
            //     Сравнение списков
            // -----------------------------
            Console.WriteLine("\nСравнение списков:");
            Console.WriteLine(list1 == list2); // False (потому что list1[1] = 99)
            Console.WriteLine(list1 != list2); // True

            // -----------------------------
            //     Оператор +
            // -----------------------------
            Console.WriteLine("\nОператор + (объединение):");
            var list3 = list1 + list2;

            for (int i = 0; i < list3.Count; i++)
                Console.WriteLine(list3[i]);

            // -----------------------------
            //     Оператор -
            // -----------------------------
            Console.WriteLine("\nОператор - (удаление элементов):");
            var list4 = list3 - list2;

            for (int i = 0; i < list4.Count; i++)
                Console.WriteLine(list4[i]);
        }
    }

}