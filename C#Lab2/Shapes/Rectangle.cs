using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 position;
        private Vector2 size;
        public bool IsSquare
        {
            get
            {
                if (size.X == size.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.position = center;
            this.size = size;
        }
        public Rectangle(Vector2 center, float width)
        {
            this.position = center;
            this.size = new Vector2(width, width);
        }
        public override float Circumference => ((size.X * 2) + (size.Y * 2));
        public override Vector3 Center => new Vector3(position, 0);
        public override float Area => (size.X * size.Y);
        public override string ToString()
        {
            return $"\nRectangle @({position.X}, {position.Y})" +
                $"\nWidth = {size.X}, Height = {size.Y}" +
                $"\nCircumference = {Circumference}" +
                $"\nArea = {Area} " +
                $"\nSquare = {IsSquare}";
        }
    }
}
