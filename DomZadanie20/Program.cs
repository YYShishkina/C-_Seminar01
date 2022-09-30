
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int height = InputSize2DArray("Input height --> ");
int width = InputSize2DArray("Intput width --> ");
int positionChecker = InputSize2DArray("Еnter the element number to be found  --> ");
int[ , ] numbers = new int [height,width];
numbers =Fell2DArray(numbers, width, height);
Console.WriteLine();
Print2DArrya(numbers, width, height);
Console.WriteLine();
if (positionChecker>=height*width) Console.WriteLine($"{positionChecker} -> there is no this element in matrix");
else Console.Write($"The element of matriх with number {positionChecker} is -> ");
FindNumber(numbers,positionChecker,width,height);
Console.WriteLine();


int InputSize2DArray(string promp){
    Console.Write(promp);
    return int.Parse(Console.ReadLine()!);
}
 int [,] Fell2DArray (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            numbers[i,j] = new Random().Next(-9,10);
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

 void FindNumber(int [,] numbers, int positionChecker,int wigth, int height){
    int numberChecker=0;
    for (int i=0; i<height; i++){
        for (int j=0; j<width; j++){                      
            if (numberChecker==positionChecker) Console.Write(numbers[i,j]);
            numberChecker=numberChecker+1;  
        }
    }
}