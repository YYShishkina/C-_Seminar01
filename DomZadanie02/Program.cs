// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input number1 ");
string number1 = Console.ReadLine();
int n1 = int.Parse(number1);
Console.WriteLine("Input number2 ");
string number2 = Console.ReadLine();
int n2 = int.Parse(number2);
Console.WriteLine("Input number3 ");
string number3 = Console.ReadLine();
int n3 = int.Parse(number3);
int max = n1;
if (n1 > max)
{
   max = n1; 
}
if (n2 > max)
{
    max = n2;  
}
if (n3 > max)
{
    max = n3;  
}
Console.WriteLine($"The bigger number is {max}");