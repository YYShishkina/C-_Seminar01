// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = new Random().Next (100,1000);
int fig1 = number/100;
int fig3 = number%10;
Console.WriteLine($"{number}, {fig1}{fig3}");
