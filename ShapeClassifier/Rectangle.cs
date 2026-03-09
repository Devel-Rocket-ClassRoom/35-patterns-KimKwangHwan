using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    public override double CalculateArea()
    {
        return Width * Height;
    }
    public int Width { get; set; }
    public int Height { get; set; }
}