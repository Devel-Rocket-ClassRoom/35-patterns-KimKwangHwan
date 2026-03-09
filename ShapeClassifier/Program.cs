using System;

Circle circle1 = new Circle { Radius = 5 };
Circle circle2 = new Circle { Radius = 15 };
Rectangle rect1 = new Rectangle { Width = 4, Height = 6 };
Rectangle rect2 = new Rectangle { Width = 5, Height = 5 };
Square sq = new Square { Side = 7 };

Console.WriteLine("=== 도형 분류기 ===");

Console.WriteLine($"원(반지름: 5): {ClassifyShape(circle1)}, {circle1.CalculateArea():F2}");
Console.WriteLine($"원(반지름: 15): {ClassifyShape(circle2)}, {circle2.CalculateArea():F2}");
Console.WriteLine($"직사각형(4x6): {ClassifyShape(rect1)}, {rect1.CalculateArea():F2}");
Console.WriteLine($"직사각형(5x5): {ClassifyShape(rect2)}, {rect2.CalculateArea():F2}");
Console.WriteLine($"정사각형(7): {ClassifyShape(sq)}, {sq.CalculateArea():F2}");


string ClassifyShape(Shape shape) => shape switch
{
    Circle { Radius: >= 10 } => "큰 원",
    Circle => "작은 원",
    Rectangle { Width: var width, Height: var height } when width == height => "정사각형 모양의 직사각형",
    Rectangle => "일반 직사각형",
    Square => "정사각형",
    _ => ""
};