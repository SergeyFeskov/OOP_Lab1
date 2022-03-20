using System;

namespace OOP_Lab1
{
    public class Vector
    {
        public Vector(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        // gets vector cords by its lenth and degree
        public Vector(float Length, double Degree)
        {
            X = (float)(Length * Math.Cos(Degree));
            Y = (float)(Length * Math.Sin(Degree));
        }

        public float GetLength()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public double GetDegree()
        {
            return Math.Atan(Y / X);
        }

        public float X;
        public float Y;
    }
}


