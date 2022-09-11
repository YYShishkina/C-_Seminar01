// 1. Пользователь вводит x и y. Программа печатает, чему равно x² + y².
//Например: 1, 2 → 5

Console.Write($"Введите координаты значени Х и Y ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
int x = int.Parse (coordinate[0]);
int y = int.Parse (coordinate[1]);
double distance = (Math.Pow(x,2) + Math.Pow(y, 2));
Console.WriteLine($"Сумма квадратов {distance}");