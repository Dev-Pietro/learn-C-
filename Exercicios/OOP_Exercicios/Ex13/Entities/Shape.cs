using System;
using Ex13.Entities.Enums;

namespace Ex13.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //metodo abstrato
    }
}