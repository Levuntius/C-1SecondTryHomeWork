namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int a;
            int b;
            int c;
            int d;
            bool positive;
            int numOfEvenDigits = 0;

            Console.WriteLine("введите четерех значное число");
            try
            {
                int fourDigitNum = int.Parse(Console.ReadLine());

                if (fourDigitNum >= 0)
                {
                    positive = true;
                }
                else
                {
                    positive = false;
                }

                if (fourDigitNum > 1000 || fourDigitNum < 9999 && fourDigitNum < -1000 || fourDigitNum > -9999)
                {

                    if (positive)
                    {
                        a = fourDigitNum / 1000;
                        b = (fourDigitNum / 100) % 10;
                        c = (fourDigitNum / 10) % 10;
                        d = fourDigitNum % 10;
                    }
                    else
                    {
                        a = (fourDigitNum / 1000) * -1;
                        b = ((fourDigitNum / 100) % 10) * -1;
                        c = ((fourDigitNum / 10) % 10) * -1;
                        d = (fourDigitNum % 10) * -1;
                    }
                    if (a % 2 == 0) 
                    {
                        numOfEvenDigits ++;
                    }
                    if (b % 2 == 0)
                    {
                        numOfEvenDigits ++;
                        }
                    if (c % 2 == 0)
                    {
                        numOfEvenDigits ++;
                    }
                    if (d % 2 == 0)
                    {
                        numOfEvenDigits++;
                    } 
                        Console.WriteLine($"Количество четных цифр: {numOfEvenDigits}");
                        Console.WriteLine($"Первая цифра: {a}");
                        Console.WriteLine($"Вторая цифра: {b}");
                        Console.WriteLine($"Третяя цифра: {c}");
                        Console.WriteLine($"Четвертая цифра: {d}");
                }

                

                else
                { 
                   Console.WriteLine("Не четерех значное число");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Непрввильный формат");
            }
           
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Деление на ноль");
            }
        }
    }
}
