// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string input1 = Console.ReadLine();
int number1 = int.Parse (input1);
string input2 = Console.ReadLine();
int number2 = int.Parse (input2);
if (number1%number2==0)
{
   Console.WriteLine($"{number2} multiple {number1}"); 
}
else
{
    Console.WriteLine($"{number1%number2}"); 
}


