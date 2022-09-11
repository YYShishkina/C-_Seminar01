// Пользователь вводит возраст. Если ему меньшу 18 лет или больше 65 лет, программа говорит, что для него есть скидка.
Console.Write($"Input client's age ");
string A = Console.ReadLine()!;
string[] coordinate = A.Split(" ");
if (
    ((int.Parse (coordinate[0]) < 18) && (int.Parse (coordinate[0]) > 0))|| (int.Parse (coordinate[0]) > 65))
{
   Console.WriteLine($"Client has discount");   
}
else 
{
    Console.WriteLine($"Client has not discount");
} 