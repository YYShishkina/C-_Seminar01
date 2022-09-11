// Пользователь вводит координаты x, y точки на плоскости. Программа печатает расстояние от начала координат (0, 0) до точки (x, y). (Используйте теорему Пифагора).
Console.Write($"Введите координаты точки А ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
double distance = Math.Sqrt(Math.Pow(int.Parse (coordinate[0]),2)+ Math.Pow(int.Parse (coordinate[1]),2));
Console.WriteLine($"Расстояние от начала координат до точки А {distance:F3}");