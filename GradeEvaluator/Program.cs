using System;

Console.WriteLine("=== 성적 평가기 ===");
Console.WriteLine($"95점: {GetGrade(95)} ({GetStatus(95)}) - {(IsPassingGrade(95) ? "합격" : "불합격")}");
Console.WriteLine($"87점: {GetGrade(87)} ({GetStatus(87)}) - {(IsPassingGrade(87) ? "합격" : "불합격")}");
Console.WriteLine($"73점: {GetGrade(73)} ({GetStatus(73)}) - {(IsPassingGrade(73) ? "합격" : "불합격")}");
Console.WriteLine($"65점: {GetGrade(65)} ({GetStatus(65)}) - {(IsPassingGrade(65) ? "합격" : "불합격")}");
Console.WriteLine($"45점: {GetGrade(45)} ({GetStatus(45)}) - {(IsPassingGrade(45) ? "합격" : "불합격")}");
Console.WriteLine($"30점: {GetGrade(30)} ({GetStatus(30)}) - {(IsPassingGrade(30) ? "합격" : "불합격")}");


string GetGrade(int score) => score switch
{
    >= 90 => "A",
    >= 80 and < 90 => "B",
    >= 70 and < 80 => "C",
    >= 60 and < 70 => "D",
    < 60 => "F"
};

string GetStatus(int score) => score switch
{
    >= 95 => "최우수",
    >= 90 and < 95 => "우수",
    >= 70 and < 90 => "보통",
    >= 40 and < 70 => "노력 필요",
    < 40 => "재수강 권장"
};

bool IsPassingGrade(int score) => score switch
{
    >= 60 => true,
    _ => false
};