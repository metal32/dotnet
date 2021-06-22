using System;
namespace Shape
{
    public class Rectangle: Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public override double Area => Length * Breadth;

        public override double Perimeter => 2 * (Length + Breadth);

        public bool IsSquare() => Length == Breadth;

        public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Breadth, 2)), 2);


    }
}
