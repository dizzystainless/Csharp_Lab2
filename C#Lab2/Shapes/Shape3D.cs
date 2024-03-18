using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape3D : Shape
    {
        public abstract float Volume { get; }
    }
}
