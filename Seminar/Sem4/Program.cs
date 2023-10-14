// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// 456 -> 3

// 78 -> 2

// 89126 -> 5

// int DigitCount (int num)
// {
//     int count = 1;
//     while (num > 10)
//     {
//         num = num/10;
//         count++;
//     }
//     return count;
// }

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(DigitCount(num));

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и еденицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

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

// void PrintArray (int[] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);


// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Vvod(string message)
// {
//     Console.WriteLine(message);
//     int x = Convert.ToInt32 (Console.ReadLine());
//     return x;
// }

// int Numbers (int A)
// {
//     int sum = 0;
//     for (int i = 0; i <= A; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// int A = Vvod ("Введите число А: ");
// Console.WriteLine(Numbers(A));

// Напишите программу, которая принимает на вход число N  и выдает произведение чисел от 1 до N

// int Vvod(string message)
// {
//     Console.WriteLine(message);
//     int x = Convert.ToInt32 (Console.ReadLine());
//     return x;
// }

// int Factorial (int n)
// {
//     int factorial = 1;
//     for (int i = 1; i <=n; i++)
//         {
//             factorial *= i;
//         }
//     return factorial;
// }

// int n = Vvod ("Введите число N: ");
// Console.WriteLine(Factorial(n));
