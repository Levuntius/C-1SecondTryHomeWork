namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bool=: true, false");
            Console.WriteLine("byte=: 0 to 255");
            Console.WriteLine("sbyte=: -128 to 127");
            Console.WriteLine("short=: -32,768 to 32,767");
            Console.WriteLine("ushort=: 0 to 65,535");
            Console.WriteLine("int=: -2,147,483,648 to 2,147,483,647");
            Console.WriteLine("uint=: 0 to 4,294,967,295");
            Console.WriteLine("long=: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            Console.WriteLine("ulong=: 0 to 18,446,744,073,709,551,615");
            Console.WriteLine("float=: decimal number (6-9 digits)");
            Console.WriteLine("double=: decimal number (15-17 digits)");
            Console.WriteLine("decimal=: decimal number (28-29 digits)");
            Console.WriteLine("char=: a single 16-bit Unicode character");
            Console.WriteLine("string=: a sequence of characters");
            Console.WriteLine("object=: any data type");

            double a = (3 + 5 * (6 + 3) - 8 * 3 + 1) / (21 + 50 / (3 + 4 * (1 + 2)));
            Console.WriteLine($"a={a}");

            double b = ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / (3 / 7 + 2.97 * (8.05 - 8.1 * 6.07));
            Console.WriteLine($"b={b}");
        }
    }
}
