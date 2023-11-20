// // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// // m = 3, n = 4.

// //  1  4   8  19
// //  5 -2  33  -2
// // 77  3   8   1

// int [,] Create2DRandomArray(int row, int column, int minValue, int maxValue) // четыре аргумента нужно чтобы создать двумерный массив
// {
//     int [,] array = new int[row, column]; // выделили память под массив
//     for (int i = 0; i < row; i++) // заполняем строчки
//     {
//         for (int j = 0; j < column; j++) //заполняем колонны
//         {
//             array[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)  // метод для печати
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             System.Console.Write(array[i, j] +" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of column: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, min, max);
// Print2DArray(myArray);


// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int SumOfMainDiagonal(int[,] array) // метод решения задачи
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++) 
        
//             if (i == j) sum = sum += array[i,j];
        
//     return sum;
// }

// System.Console.WriteLine(SumOfMainDiagonal(myArray)); // метод для печати 


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран. m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] CreateArray(int row, int column) 
// {
//     int [,] array = new int[row, column]; // выделили память под массив
//     for (int i = 0; i < row; i++) // заполняем строчки
//     {
//         for (int j = 0; j < column; j++) //заполняем колонны
//         {
//             array[i, j] = i+j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)  // метод для печати
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             System.Console.Write(array[i, j] +" ");
//         }
//         System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input number of column: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray (rows, columns);
// Print2DArray(myArray);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// Console.Write("Input row: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(row, columns, min, max);
// Console.WriteLine("Start 2d array: ");
// Print2DArray(myArray);
// Refill2DArray(myArray);
// Console.WriteLine("New 2d array: ");
// Print2DArray(myArray);


// int [,] Create2DRandomArray(int row, int column, int minValue, int maxValue) // четыре аргумента нужно чтобы создать двумерный массив
// {
//     int [,] array = new int[row, column]; // выделили память под массив
//     for (int i = 0; i < row; i++) // заполняем строчки
//     {
//         for (int j = 0; j < column; j++) //заполняем колонны
//         {
//             array[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)  // метод для печати
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             System.Console.Write(array[i, j] +" ");
//         }
//         System.Console.WriteLine();
//     }
// }


// void Refill2DArray(int[,] array) // Решение
//     {
//         for (int i = 0; i<array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if(i%2 == 0 && j%2 == 0)
//                 {
//                     array[i,j]*=array[i,j];
//                 }
//             }
//         }
//     }


// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.

//  1  4   8  19
//  5 -2  33  -2
// 77  3   8   1

// int [,] Create2DRandomArray(int row, int column, int minValue, int maxValue) // четыре аргумента нужно чтобы создать двумерный массив
// {
//     int [,] array = new int[row, column]; // выделили память под массив
//     for (int i = 0; i < row; i++) // заполняем строчки
//     {
//         for (int j = 0; j < column; j++) //заполняем колонны
//         {
//             array[i, j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }

