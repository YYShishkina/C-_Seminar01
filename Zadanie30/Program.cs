// See https://aka.ms/new-console-template for more information
Console.WriteLine();
// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int height = InputParametr("Input height --> ");
int width = InputParametr("Intput width --> ");
int[ , ] numbers = new int [height,width];
Console.WriteLine();
numbers =Fell2DArray(numbers, width, height);
Print2DArrya(numbers, width, height);
Console.WriteLine();
int sumNumbers = CalculateSumNumbers(numbers,width,height);
Console.WriteLine ($"Sum element main diagonal --> {sumNumbers}");
Console.WriteLine();


int InputParametr(string promp){
    Console.Write(promp);
    return int.Parse(Console.ReadLine()!);
}

 
 int [,] Fell2DArray (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            numbers[i,j] = new Random().Next(0,11);
        }
    }
    return numbers;
 }

 int CalculateSumNumbers (int [,] numbers, int wigth, int height){
    sumNumbers=0;
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            if (i==j){
                sumNumbers = sumNumbers+numbers[i,j];
            }
        }
    }
    return sumNumbers;
 }

 void Print2DArrya (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            Console.Write ($"{numbers [i,j],3} ");
        }
        Console.WriteLine();
    }
 }