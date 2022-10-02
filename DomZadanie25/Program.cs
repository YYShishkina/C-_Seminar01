
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int height = InputHeightWidth("Input Height");
int width = InputHeightWidth("Input Width");
int depth = InputHeightWidth("Input depth");
int [,,] array = new int [height,width,depth];
Console.WriteLine();
Console.WriteLine("Created 3DArray");
array = Fill3DArray(array);
Print3DArray(array);
Console.WriteLine();


    

int InputHeightWidth( string comments)
{
    Console.Write($"{comments} --> ");
    return int.Parse(Console.ReadLine()!);
}

int[,,] Fill3DArray (int [,,] numbers)
{
    int element=0;
    for (int i=0; i<numbers.GetLength(0); i++)
    {
        for (int j=0; j<numbers.GetLength(1); j++)
        {
            for (int k=0; k<numbers.GetLength(2); k++)
            {
                numbers[i,j,k] = element;
                element++;
            }
            
        }
    }
    return numbers;
}

void Print3DArray (int [,,] numbers)
{
    for (int i=0; i<numbers.GetLength(0); i++)
    {
        for (int j=0; j<numbers.GetLength(1); j++)
        {
            for (int k=0; k<numbers.GetLength(2); k++)
            {
                Console.Write($"{numbers[j,k,i],3}({j},{k},{i}) ");
            }
            Console.WriteLine(); 
        }
    }
}


