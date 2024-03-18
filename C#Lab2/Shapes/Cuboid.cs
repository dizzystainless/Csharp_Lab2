using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Cuboid : Shape3D
    {
        public Vector3 center;
        public Vector3 size;
        public bool IsCube
        {
            get
            {
                if (size.X == size.Y && size.Y == size.Z)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }
        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            this.size = new Vector3(width, width, width);
        }

        public override float Volume => (size.X * size.Y * size.Z);
        public override Vector3 Center => new Vector3(center.X, center.Y, center.Z);
        public override float Area => ((2 * (size.X * size.Z))+ (2 * (size.X * size.Y)) + (2 * (size.Z * size.Y)));
        public override string ToString()
        {
            return $"\nCuboid @({center.X}, {center.Y}, {center.Z})" +
                $"\nWidth = {size.X}, Height = {size.Y}, Length = {size.Z} " +
                $"\nArea = {Area}" +
                $"\nVolume = {Volume}" +
                $"\nCube = {IsCube}";
        }

    }
}
