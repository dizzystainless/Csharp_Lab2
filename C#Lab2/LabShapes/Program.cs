using Shapes;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace LabShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;  //Viktigt! :)

            double sumTriangleCircumference = 0;
            double sumAllAreas = 0;
            Shape3D volumeBig = null;
            var shapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());
            }

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
                var areas = s;
                sumAllAreas += areas.Area;

                if (s is Triangle)
                {
                    var triangle = s as Triangle;
                    sumTriangleCircumference += triangle.Circumference;  //Om det är en triangel, räkna ihop alla omkretsar och spara i ny variabel
                }

                if (s is Shape3D)
                { 
                    var volumeShape = s as Shape3D; // Om det är en 3D Shape, ska programmet göra enligt nedan

                    if (volumeBig == null )
                    {
                        volumeBig = volumeShape;  //Den första 3d shapen i listan 

                    }
                    else
                    {

                        if (volumeBig.Volume < volumeShape.Volume)  //Jämför den första shapen med nästkommande för att se vilken som har störst volym osv
                        {
                            volumeBig = volumeShape;
                        }
                    }
                }
            }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nSum of all triangle's circumference: {sumTriangleCircumference}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nAverage area of all shapes in the list: " + sumAllAreas / 20);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nThe 3D shape with the biggest volume is: {volumeBig}");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();

                Console.Write("\nPress any key to continue . . .");
                Console.ReadKey();
            
        }
    }
}
