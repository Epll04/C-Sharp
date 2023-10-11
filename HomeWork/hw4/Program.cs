// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Нужно сделать цикл, чтобы "А" было умножено на само себя "B" раз

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = 1;
// if (b<1)
// Console.Write("Число B должно быть натуральным\n ");
// else
// {
// while (b!=0)
// {
// c = c * a;
// b = b-1;
// }
// Console.Write($"Число A в натуральной степени B равно {c}");
// }


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summ = 0;
//     while (n>0)
//     {
//     int b = n % 10;
//     summ = summ +b;
//     n = n/10;
//     }
// Console.Write($"сумма цифр в числе равно {summ}");

//===========================================================================================================

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int[] CreateRandomArray(int size, int minValue, int maxValue)  // пишем метод для создания массива
{
    int[] array = new int[size]; //тело метода - при создании массива, такая конструкция
                                // выделяет память для аргумента size в компьютере для массива целых чисел размером size
    for (int i = 0; i < size; i++) // Чтобы пройтись по массиву обратиться к каждому элементу.
                                      //и когда речь идет о массиве всегда цикл For
    {
        array[i] = new Random().Next(minValue, maxValue + 1); // заполняем массив
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);



