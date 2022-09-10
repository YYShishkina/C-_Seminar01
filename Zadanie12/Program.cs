// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Hello, World!");
Console.Write($"Введите координаты точки А и B ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
int xA = int.Parse (coordinate[0]);
int yA = int.Parse (coordinate[1]);
int xB = int.Parse (coordinate[2]);
int yB = int.Parse (coordinate[3]);
double distance = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB));
Console.WriteLine($"Расстояние между точками {distance}");