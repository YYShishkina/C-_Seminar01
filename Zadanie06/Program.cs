// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = new Random().Next (10,100);
int fig1 = number/10;
int fig2 = number%10;
Console.WriteLine($"{number}, {fig1}, {fig2}");
if (fig1>fig2)
{
    Console.WriteLine($"Bigger {fig1}");
}
else 
{
    Console.WriteLine($"Bigger {fig2}");
}
