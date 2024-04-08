using System;

namespace Struct_8
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}