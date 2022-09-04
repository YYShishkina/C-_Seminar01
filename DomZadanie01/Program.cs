// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number1 ");
string number1 = Console.ReadLine();
int n1 = int.Parse(number1);
Console.WriteLine("Input number2 ");
string number2 = Console.ReadLine();
int n2 = int.Parse(number2);
if (n1 > n2)
{
   Console.WriteLine($"{n1} Bigger {n2}"); 
}
else if (n2 > n1)
{
    Console.WriteLine($"{n2} Bigger {n1}");  
}
else
{
    Console.WriteLine($"{n2} equals {n1}");  
}
