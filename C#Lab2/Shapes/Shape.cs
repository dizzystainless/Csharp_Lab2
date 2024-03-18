using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private static Random rnd = new Random();
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        // Generate shape with random center in [0..10], [0..10], [0..10]
        public static Shape GenerateShape() => GenerateShape(new Vector3((float)rnd.NextDouble() * 10, 
                                                                        (float)rnd.NextDouble() * 10, 
                                                                        (float)rnd.NextDouble() * 10));

        /// <summary>
        /// Generate a random shape with random coordinates
        /// </summary>
        /// <param name="position">Center of figure to generate</param>
        /// <returns></returns>
        public static Shape GenerateShape(Vector3 position)
        {
            int i = rnd.Next(7);
            float scaleFactor = 5;      // Because rnd.NextDouble returns a number between 0.0f and 1.0f
            return i switch
            {
                0 => new Circle(new Vector2(position.X, position.Y), (float)rnd.NextDouble() * scaleFactor),
                1 => new Rectangle(new Vector2(position.X, position.Y),(float)rnd.NextDouble() * scaleFactor),
                2 => new Rectangle(new Vector2(position.X, position.Y), new Vector2(position.X,position.Y)/*rnd.NextDouble() * scaleFactor*/),   //Verkar fungera fast jag inte lagt till random siffror på denna? (för det fungerade inte..) 
                3 => GenerateTriangle(new Vector2(position.X, position.Y)),
                4 => new Sphere(position, (float)rnd.NextDouble() * scaleFactor),
                5 => new Cuboid(position, Vector3.One * (float)rnd.NextDouble() * scaleFactor),
                6 => new Cuboid(position, new Vector3((float)rnd.NextDouble() * scaleFactor, (float)rnd.NextDouble() * scaleFactor, (float)rnd.NextDouble() * scaleFactor)),
                _ => null
            };
        }

        private static Triangle GenerateTriangle(Vector2 position)
        {
            Vector2 p1 = new Vector2((float)rnd.NextDouble(), (float)rnd.NextDouble());
            Vector2 p2 = new Vector2((float)rnd.NextDouble(), (float)rnd.NextDouble());
            Vector2 p3 = new Vector2(3.0f * position.X - p1.X - p2.X, 3.0f * position.Y - p1.Y - p2.Y);
            return new Triangle(p1, p2, p3);
        }
    }
}
