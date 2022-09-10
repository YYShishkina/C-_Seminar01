// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string input1 = Console.ReadLine()!;
int n = int.Parse (input1);
//string input2 = Console.ReadLine();
//int number2 = int.Parse (input2);

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i},");
}