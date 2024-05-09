namespace Assignment1._3._1_newest_
{
    
class AreaCalculator
        {
            public static void Main()
            {
                Console.WriteLine("Area Calculator for Square and Rectangle");

                // Calculate area of square
                Console.WriteLine("Enter the length of the side of the square: ");
                int side = Convert.ToInt32(Console.ReadLine());
                int areaSquare = side * side;
                Console.WriteLine("The area of the square is: " + areaSquare);

                // Calculate area of rectangle
                Console.WriteLine("Enter the length of the rectangle: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle: ");
                int width = Convert.ToInt32(Console.ReadLine());
                int areaRectangle = length * width;
                Console.WriteLine("The area of the rectangle is: " + areaRectangle);

                //Calculate area of triangle
                Console.WriteLine("Enter the length of the side 1 of the triangle");
                int side1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the length of the side 2 of the triangle");
                int side2 = Convert.ToInt32(Console.ReadLine());
                int areaTriangle = side1 * side2 / 2;
                Console.WriteLine("The area of the triangle is: " + areaTriangle);

            }
        }

    }

    

