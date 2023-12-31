﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size, int minValue, int maxValue)  // пишем метод для создания массива
// {
//     int[] array = new int[size]; //тело метода - при создании массива, такая конструкция
//                                 // выделяет память для аргумента size в компьютере для массива целых чисел размером size
//     for (int i = 0; i < size; i++) // Чтобы пройтись по массиву обратиться к каждому элементу.
//                                       //и когда речь идет о массиве всегда цикл For
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // заполняем массив
//     }
//     return array;
// }

// void PrintArray (int[] array) //метод PrintArray - чтобы вывести на экран наш массив
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// System.Console.WriteLine();
// }

// int CountNumbers(int[] array)   // Метод для решения задачи
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i]%2 == 0)
//        {
//             count++; 
//        }
//     }
//     return count;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);

// int count = CountNumbers(myArray);

// System.Console.WriteLine(count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] CreateRandomArray(int size, int minValue, int maxValue)  // пишем метод для создания массива
// {
//     int[] array = new int[size]; //тело метода - при создании массива, такая конструкция
//                                 // выделяет память для аргумента size в компьютере для массива целых чисел размером size
//     for (int i = 0; i < size; i++) // Чтобы пройтись по массиву обратиться к каждому элементу.
//                                       //и когда речь идет о массиве всегда цикл For
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // заполняем массив
//     }
//     return array;
// }

// void PrintArray (int[] array) //метод PrintArray - чтобы вывести на экран наш массив
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// System.Console.WriteLine();
// }

// int Summ(int[] array) // Метод для решения задачи
// {
//     int summ = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         summ += array[i];
//     }
//     return summ;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// int summ = Summ(myArray);
// System.Console.WriteLine(summ);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateRandomArray(int size, int minValue, int maxValue)  // пишем метод для создания массива
{
    double[] array = new double[size]; //тело метода - при создании массива, такая конструкция
                                // выделяет память для аргумента size в компьютере для массива целых чисел размером size
    for (int i = 0; i < size; i++) // Чтобы пройтись по массиву обратиться к каждому элементу.
                                      //и когда речь идет о массиве всегда цикл For
    {
        array[i] = new Random().Next(minValue*10, maxValue*10 + 1)/10.0; // заполняем массив
    }
    return array;
}

void PrintArray (double[] array) //метод PrintArray - чтобы вывести на экран наш массив
{
    for (int i=0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
System.Console.WriteLine();
}

double FindMinNumber(double[] array)   // Метод для решения задачи
{
    double MinNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
        }
    }
    return MinNumber;
}

double FindMaxNumber(double[] array)   // Метод для решения задачи
{
    double MaxNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxNumber)
        {
            MaxNumber = array[i];
        }
    }
    return MaxNumber;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);
double Min = FindMinNumber(myArray);
Console.WriteLine(Min);
double Max = FindMaxNumber(myArray);
Console.WriteLine(Max);
Console.WriteLine(Max-Min);

