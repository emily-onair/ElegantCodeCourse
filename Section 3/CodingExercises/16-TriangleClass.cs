using System;

namespace Coding.Exercise
{
    public class Triangle
    {
        public Triangle(int @base, int height) {
            Base = @base;
            Height = height;
        }
        
        private int Base;
        private int Height;
        
        public int CalculateArea() {
            return ((Base * Height) / 2);
        }
        
        public string AsString() {
            return $"Base is {Base}, height is {Height}";
        }
    }
}
