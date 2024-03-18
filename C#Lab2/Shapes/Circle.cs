using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape2D
    {
        private Vector2 position;
        private float radius;
        public Circle(Vector2 center, float radius)
        {
            this.position = center; //Vector2 har alltid en x och en y kordinat, är en position i en 2D värld
            this.radius = radius;
        }

        public override Vector3 Center => new Vector3(position, 0); //En constructor kan ha flera "signaturer" som skapar overloads
        public override float Circumference => (radius + radius) * MathF.PI;
        public override float Area => (radius * radius) * MathF.PI;
        public override string ToString()
        {
            return $"\nCircle @({position.X}, {position.Y})" +
                $"\nRadius = {radius}" +
                $"\nCircumference = {Circumference}" +
                $"\nArea = {Area}";
        }

    }
}
