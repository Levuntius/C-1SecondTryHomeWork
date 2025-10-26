namespace C_1SecondTryHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.a//
            double Length_of_a_rectangle = 10.0;
            double Width_of_a_rectangle = 5.0;
            double Area_of_a_rectangle = Length_of_a_rectangle * Width_of_a_rectangle;
            Console.WriteLine("Area of a rectangle: " + Area_of_a_rectangle);
           

            //5.b//
            double Radius_of_a_circle = 7.5;
            double Area_of_a_circle = Math.PI * Math.Pow(Radius_of_a_circle, 2);
            Console.WriteLine("Area of a circle: " + Area_of_a_circle);
            

            //5.c//
            double Base_of_a_triangle = 8.0;
            double Height_of_a_triangle = 6.0;
            double Area_of_a_triangle = 0.5 * Base_of_a_triangle * Height_of_a_triangle;
            Console.WriteLine("Area of a triangle: " + Area_of_a_triangle);


            //5.d//
            double Side_a = 5.0;
            double Side_b = 6.0;
            double Side_c = 7.0;
            double Semi_perimeter = (Side_a + Side_b + Side_c) / 2;
            double Area_of_triangle_Heron = Math.Sqrt(Semi_perimeter * (Semi_perimeter - Side_a) * (Semi_perimeter - Side_b) * (Semi_perimeter - Side_c));
            Console.WriteLine("Area of a triangle using Heron's formula: " + Area_of_triangle_Heron);






        }
    }
}
