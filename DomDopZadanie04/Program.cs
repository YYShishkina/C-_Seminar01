// See https://aka.ms/new-console-template for more information
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