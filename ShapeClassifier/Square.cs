using System;
using System.Collections.Generic;
using System.Text;

public class Square : Shape
{
    public override double CalculateArea()
    {
        return Side * Side;
    }
    public int Side { get; set; }
}