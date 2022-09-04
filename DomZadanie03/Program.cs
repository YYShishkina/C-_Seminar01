Console.WriteLine("Input number ");
string number1 = Console.ReadLine();
int n1 = int.Parse(number1);
int ostatok = n1 % 2;
if (ostatok == 0)
{
   Console.WriteLine($"{n1} Chetnoe"); 
}
else
{
    Console.WriteLine($"{n1} NeChetnoe"); 
}
