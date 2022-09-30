// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int height = InputSize2DArray("Input height --> ");
int width = InputSize2DArray("Intput width --> ");
int[ , ] numbers = new int [height,width];
numbers =Fell2DArray(numbers, width, height);
Console.WriteLine();
Print2DArrya(numbers, width, height);
Console.WriteLine();
FindArithmeticMean(numbers,width,height);
Console.WriteLine();


int InputSize2DArray(string promp){
    Console.Write(promp);
    return int.Parse(Console.ReadLine()!);
}
 int [,] Fell2DArray (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            numbers[i,j] = new Random().Next(0,10);
        }
    }
    return numbers;
 }

 void Print2DArrya (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            Console.Write ($"{numbers [i,j],5} ");
        }
        Console.WriteLine();
    }
 }

 void FindArithmeticMean(int [,] numbers, int wigth, int height){
    int arithmeticMean=0;
    for (int i=0; i<height; i++){
        for (int j=0; j<width; j++){                      
            arithmeticMean=arithmeticMean+numbers[i,j];
        }
        Console.WriteLine ($"Arithmetic mean the {i+1} line is -> {arithmeticMean/width}");
        arithmeticMean=0;
    }
}