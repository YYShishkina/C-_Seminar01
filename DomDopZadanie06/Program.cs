//Пользователь вводит координаты двух точек A и B на плоскости. Программа определяет, какая из них дальше от начала координат.
Console.Write($"Введите координаты точки А и В ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
double DistanceA = Math.Sqrt(Math.Pow(int.Parse (coordinate[0]),2)+ Math.Pow(int.Parse (coordinate[1]),2));
double DistanceB = Math.Sqrt(Math.Pow(int.Parse (coordinate[2]),2)+ Math.Pow(int.Parse (coordinate[3]),2));
Console.WriteLine($"Расстояние от начала координат до точки А {DistanceA:F3} до точки В  {DistanceB:F3}" );
if (DistanceA > DistanceB)
{
    Console.WriteLine($"А дальше");
}
else if (DistanceA < DistanceB) 
{
    Console.WriteLine($"B дальше");
}
else 
{
    Console.WriteLine($"Точки находятся на одинаковом расстоянии от начала координат");
}