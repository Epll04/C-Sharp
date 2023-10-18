// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



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
//     System.Console.WriteLine();
// }

// int[] ReverseArray(int[] array)   // Метод для решения задачи
// {
//     int temp;
//     for (int i = 0; i< array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max); //Печатаем начальный массив 
// PrintArray(myArray);
// myArray = ReverseArray(myArray); //Печатаем переделанный массив
// PrintArray(myArray);

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// string DecimalToBinary(int num) //метод решения задачи
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//        result = num % 2 + result;
//        num /= 2;
//     }
//     return result;
// }


// System.Console.WriteLine("Input num");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine (DecimalToBinary(num));


// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// System.Console.Write("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter third number: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// bool Triangle (int number1, int number2, int number3)
// {
//     if((number1<(number2+number3)) && (number2<(number1+number3)) && (number3<(number2+number1)))
//     {
//         return true;
//     }
//     else
//      {
//         return false;
//     }
// }
// System.Console.WriteLine (Triangle (number1, number2, number3));



// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
using System;


    static void Main(string[] args)
    {
        Console.Write("Input N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] fibonachi = new int [N];
        Console.Write($"Если N = {N} ->" );
        PrintArray(Fibonachi(fibonachi));
    }

    static int[] Fibonachi(int[] fibonachi)
    {
        fibonachi[0] = 0;
        fibonachi[1] = 1;
        for(int i = 2; i < fibonachi.Length; i++)
        {
            fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];
        }
        return fibonachi;
    }

    void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]}], ");
            }
            else if (i == array.Length-1)
            {
            Console.Write($"[{array[i]}], ");
            }
            else
            {
            Console.Write($"[{array[i]}], ");
            }
        }
    }









// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.


