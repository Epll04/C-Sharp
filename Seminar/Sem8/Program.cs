// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Например, задан массив:

// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 

// В итоге получается вот такой массив:

// 8 4 2 4 
// 5 9 2 3 
// 1 4 7 2

int [,] Create2DRandomArray(int row, int column, int minValue, int maxValue) // четыре аргумента нужно чтобы создать двумерный массив
{
    int [,] array = new int[row, column]; // выделили память под массив
    for (int i = 0; i < row; i++) // заполняем строчки
    {
        for (int j = 0; j < column; j++) //заполняем колонны
        {
            array[i, j] = new Random().Next(minValue, maxValue +1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)  // метод для печати
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            System.Console.Write(array[i, j] +" ");
        }
        System.Console.WriteLine();
    }
}

int[,] ChangeArrayRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >=array.GetLength(0)|| row1<0 || row2<0)
    {
        System.Console.WriteLine("Index of row is out of bound !");
        return array;
    }
    else 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
    return array;
}

System.Console.WriteLine("Input row: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input row1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input row2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray (row,column,minValue,maxValue);
Console.WriteLine();
Print2DArray (myArray);
Console.WriteLine();
Print2DArray (ChangeArrayRows(myArray, row1, row2));

