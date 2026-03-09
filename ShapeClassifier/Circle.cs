using System;
using System.Collections.Generic;
using System.Text;

public class Circle : Shape
{
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    public int Radius { get; set; }
}