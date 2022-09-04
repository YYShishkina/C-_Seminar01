// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number ");
string number = Console.ReadLine();
int n = int.Parse(number);
for (int i = -n; i <= n; i++)
{
    Console.WriteLine(i);
}