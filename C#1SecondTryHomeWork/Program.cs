namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            bool positive;
            int fourDigitNum;
            int numOfEvenDigits = 0;

            Console.WriteLine("введите четерех значное число");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out fourDigitNum))
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }
                break;
            }

            if (fourDigitNum >= 0)
                {
                    positive = true;
                }
                else
                {
                    positive = false;
                }

                if (fourDigitNum >= 1000 && fourDigitNum <= 9999 || fourDigitNum <= -1000 && fourDigitNum >= -9999)
                {

                    if (positive)
                    {
                        for(int i = 1000; i != 0; i/= 10)
                        
                            if (fourDigitNum / i % 10 % 2 == 0)
                            {
                               numOfEvenDigits++;
                            }

                    }
                    else
                    {
                        for (int i = 1000; i != 0; i /= 10)

                            if (-1 * fourDigitNum / i % 10 % 2 == 0)
                            {
                               numOfEvenDigits++;
                            }
                }
                    
                    
                        Console.WriteLine($"Количество четных цифр: {numOfEvenDigits}");
                        
                }

                

                else
                { 
                   Console.WriteLine("Не четерех значное число");
                }
            

           
           
        }
    }
}
