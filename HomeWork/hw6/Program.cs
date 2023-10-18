// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array(int m) // пишем метод для создания массива
{
    int[] array = new int[m]; //тело метода - при создании массива, такая конструкция выделяет память для аргумента size в компьютере для массива целых чисел размером size
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int[] array) //метод PrintArray - чтобы вывести на экран наш массив
{
    for (int i=0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
System.Console.WriteLine();
}

int CountN(int[] Array)
{
    int count = 0;
    for (int i = 1; i<Array.Length; i = i+1)
    {
        if(i > 0) 
        {
            count++;
        }
    }
    return count;
}

int[] myArray = Array(m);
PrintArray(myArray);

System.Console.Write(CountN);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1,
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)




