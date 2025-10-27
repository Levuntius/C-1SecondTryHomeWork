namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.a//
            double lengthOfARectangle = 10.0;
            double widthOfARectangle = 5.0;
            double areaOfARectangle = lengthOfARectangle * widthOfARectangle;
            Console.WriteLine("Area of a rectangle: " + areaOfARectangle);
           

            //5.b//
            double radiusOfACircle = 7.5;
            double areaOfAircle = Math.PI * Math.Pow(radiusOfACircle, 2);
            Console.WriteLine("Area of a circle: " + areaOfACircle);
            

            //5.c//
            double baseOfATriangle = 8.0;
            double heightOfATriangle = 6.0;
            double areaOfATriangle = 0.5 * baseOfATriangle * heightOfATriangle;
            Console.WriteLine("Area of a triangle: " + areaOfATriangle);


            //5.d//
            double sideA = 5.0;
            double sideB = 6.0;
            double sideC = 7.0;
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double areaOfTriangleHeron = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            Console.WriteLine("Area of a triangle using Heron's formula: " + areaOfTriangleHeron);






        }
    }
}
