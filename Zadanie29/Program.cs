// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4


int height = InputParametr("Input height --> ");
int width = InputParametr("Intput width --> ");
int[ , ] numbers = new int [height,width];
numbers =Fell2DArray(numbers, width, height);
Print2DArrya(numbers, width, height);
Console.WriteLine();
numbers= ChangeEvenElements2DArray(numbers,width,height);
Print2DArrya(numbers, width, height);


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

 int [,] ChangeEvenElements2DArray (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            if ((i%2==0) && (j%2==0)){
                numbers [i,j] = numbers[i,j]*numbers[i,j];
            }
        }
    }
    return numbers;
 }

 void Print2DArrya (int [,] numbers, int wigth, int height){
    for (int i=0; i<height; i++){
        for (int j=0; j<wigth; j++){
            Console.Write ($"{numbers [i,j],3} ");
        }
        Console.WriteLine();
    }
 }