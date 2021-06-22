using System;
namespace Shape
{
    public class Square: Shape
    {
        public int Length { get; }

        public Square(int length):base()
        {
            Length = length;
        }

        public override double Area => Math.Pow(Length, 2);
        public override double Perimeter => 4 * Length;

        public double Diagonal => Math.Round(Math.Sqrt(2) * Length, 2);
    }
}
