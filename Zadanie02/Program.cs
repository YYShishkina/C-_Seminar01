// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input first number ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
Console.WriteLine("Input second number ");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if (number1 == (number2*number2))
{
   Console.WriteLine("First number is square second numer");
}
else if (number2 == (number1*number1))
{
   Console.WriteLine("Second number is square first numer"); 
}
else 
{
    Console.WriteLine("First and Second number is not square each other"); 
}

