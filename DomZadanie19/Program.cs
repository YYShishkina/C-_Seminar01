// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int height = InputSize2DArray("Input height --> ");
int width = InputSize2DArray("Intput width --> ");
double[ , ] numbers = new double [height,width];
numbers =Fell2DArray(numbers, width, height);
Print2DArrya(numbers, width, height);
Console.WriteLine();



int InputSize2DArray(string promp){
    Console.Write(promp);
    return int.Parse(Console.ReadLine()!);
}
 double [,] Fell2DArray (double [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            numbers[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-1, 2), 1);
        }
    }
    return numbers;
 }

 void Print2DArrya (double [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            Console.Write ($"{numbers [i,j],5} ");
        }
        Console.WriteLine();
    }
 }