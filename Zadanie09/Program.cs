Console.WriteLine("Hello, World!");
string input1 = Console.ReadLine();
int number1 = int.Parse (input1);
string input2 = Console.ReadLine();
int number2 = int.Parse (input2);
if ((number1*number1==number2)||(number2*number2==number1))
{
   Console.WriteLine($"Yes"); 
}
else
{
    Console.WriteLine($"No");
} 