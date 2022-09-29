// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int height = InterInt("Input height --> ");
int width = InterInt("Intput width --> ");
int[ , ] numbers = new int [height,width];
Print(numbers, height,width);
Console.WriteLine();
numbers=FillMatrix(numbers, height,width);
Print(numbers, height,width);


int InterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

float InterFloat(string prompt)
{
    Console.Write(prompt);
    return float.Parse(Console.ReadLine()!);
}

int [ , ] FillMatrix(int [ , ] numbers, int height, int width)
{
     for (int i=0; i<height; i++)
     {
         for (int j=0; j<width; j++)
         {
             numbers[i,j] = new Random().Next(-10,11);
         }
     }
     return numbers;
}    

void Print(int [,] numbers, int height, int width){
for (int i=0; i<height; i++){
    for (int j=0; j<width; j++){
        Console.Write ($"{numbers [i,j],3} ");
    }
    Console.WriteLine();
}
}