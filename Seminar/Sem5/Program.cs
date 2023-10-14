// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна -20.


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
// System.Console.WriteLine();
// }

// void FindMinMaxSum(int[] array)
// {
//     int positiveSum = 0;
//     int negativeSum = 0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             positiveSum = positiveSum + array[i];
//         }
//         else 
//         {
//             negativeSum = negativeSum + array[i];
//         }
//     }
//     System.Console.WriteLine ($"positiveSum is {positiveSum}, negativeSum is {negativeSum}");
// }


// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// FindMinMaxSum(myArray);

// Задача 4. **** Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]

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
// System.Console.WriteLine();
// }

// int QuantityInTheSegment(int max, int min, int[] array)
// {
//     int count = 0;
//     for (int i=0; i < array.Length; i++)
//     {
//        if (array[i] > min && array[i] < max) 
//        {
//             count = count+1;
//        }
//     }
//     return count;
// }

// System.Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input minimal value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input maximal value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine (QuantityInTheSegment(max,min,myArray));


//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
System.Console.WriteLine();
}

int[] ChangeDigit(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
    return array;
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(myArray);
PrintArray(ChangeDigit(myArray));




// Вернуться к верхней задаче !!
// Задача 3. Напишите программу, которая определяет, присутсвует ли заданное число в массиве.
