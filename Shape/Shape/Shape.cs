﻿using System;
namespace Shape
{
    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        public static double GetArea(Shape shape) => shape.Area;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;
    }
}
