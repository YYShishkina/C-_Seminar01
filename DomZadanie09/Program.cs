//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write($"Введите координаты точки А и B ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
int xA = int.Parse (coordinate[0]);
int yA = int.Parse (coordinate[1]);
int zA = int.Parse (coordinate[2]);
int xB = int.Parse (coordinate[3]);
int yB = int.Parse (coordinate[4]);
int zB = int.Parse (coordinate[5]);
double distance = Math.Sqrt((xA-xB)*(xA-xB)+(yA-yB)*(yA-yB)+(zA-zB)*(zA-zB));
Console.WriteLine($"Расстояние между точками {distance:F3}");