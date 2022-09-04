
Console.WriteLine("Input number ");
string number = Console.ReadLine();
int n = int.Parse(number);
for (int i = 1; i <= n; i++)
{
    int ostatok = i % 2;
    if (ostatok == 0)
    {
        Console.Write($"{i}, ");
    }
}