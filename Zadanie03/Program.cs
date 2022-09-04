// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input daynumer ");
string input = Console.ReadLine();
int daynumber = int.Parse(input);
//Console.WriteLine("Hello, World!");
if (daynumber == 1)
{
    Console.WriteLine("monday");
}
else if (daynumber == 2)
{
    Console.WriteLine("tuesday");
}
else if (daynumber == 3)
{
    Console.WriteLine("wednesday");
}
else if (daynumber == 4)
{
    Console.WriteLine("thursday");
}
else if (daynumber == 5)
{
    Console.WriteLine("friday");
}
else if (daynumber == 6)
{
    Console.WriteLine("saturday");
}
else if (daynumber == 7)
{
    Console.WriteLine("sunday");
}