// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных коордит точек в этой четверти

//void FindCoordinates(int quarter)
//{
//    if (quarter <= 4 && quarter >= 1)
//    {
//        if(quarter == 1)
//        {
//           System.Console.WriteLine("x+ y+");
//        }
//        if(quarter == 2)
//        {
//            System.Console.WriteLine("x- y+");
//        }
//       if(quarter == 3)
//        {
//            System.Console.WriteLine("x- y-");
//        }
//         if(quarter == 4)
//        {
//            System.Console.WriteLine("x+ y-");
//        } 
//    }
//    else
//    {
//        System.Console.Write("invalid input");
//    }
//}
//System.Console.Write("input quarter num: ");
//int num = Convert.ToInt32(Console.ReadLine());

//FindCoordinates(num);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве
// А (3,6); B (2,1) -> 5.09
// A (7,-5); B (1,-1) -> 7,21

//double FindDistance(double xa, double ya, double xb, double yb)
//{
//    return Math.Round(Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2)),2);
//
//    //Math.Sqrt() - это метод математического класса, который используется для вычисления квадратного корня из указанного числа.
//    //Math.Pow (x,y) - возведение числа x в степень y
//    //Math.Round — это метод округления к ближайшему числу или к ближайшему числу с заданным количеством знаков после запятой. 
//   //Работает с типами decimal и double, в параметрах можно встретить три вида параметров:
//}
//System.Console.Write("input xa coord: ");
//double xa = Convert.ToDouble(Console.ReadLine());
//System.Console.Write("input ya coord: ");
//double ya = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("input xb coord: ");
//double xb = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("input yb coord: ");
//double yb = Convert.ToInt32(Console.ReadLine());
//
//System.Console.Write(FindDistance(xa,ya,xb,yb));

// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2-> 1,4

void Kvadrats(int N)  // вопрос Андрею: Почему здесь тип данных void ?
{
    int index = 1;  // вопрос Андрею: в этой части кода понятно что вычисляется квадрат числа, а зачем нужна вторая часть кода ?
    while (index <= N)
    {
        System.Console.Write($"{index * index}, ");
        index++;
    }
}
int Vvod(string message)   //вопрос Андрею: Зачем нужна эта часть кода, зачем нужна каждая строчка ?
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}
Kvadrats(Vvod("Введите число: "));



// void printHeader()
// {
//     System.Console.Write("****Header 23456****")
// }
// printHeader();

// int max2numbers(int a, int b){
//     int max = 0;

//     if(a > b)
//     {
//         max = a;
//     }
//     else
//     {
//         max = b;
//     }
//     return max;
// }
// int a = 2;
// int b = 22;

// int m = max2numbers(a, b);

// int c = 33;
// int d = 22;

// int max = max2numbers(c, d);

// printHeader();


// Напишите программу, которая принимает на вход координаты точки
// (X and Y), причем X и Y не равно 0 и выдает номер чатверти плоскости,
// в которой находится эта точка.

// int Vvod(string message)
// {
//     System.Console.Write(message);
//     int number = Convert.ToInt32(System.Console.ReadLine());
//     return number;
// }
// int x = Vvod("Введите координату X: ");
// int y = Vvod("Введите координату Y: ");
// int quarter(int A, int B)
// {
//     if(A > 0 && B > 0) return 1;
//     if(A < 0 && B > 0) return 2;
//     if(A < 0 && B < 0) return 3;
//     if(A > 0 && B < 0) return 4;
//     else return 0;
// }
// System.Console.WriteLine(quarter(x,y));


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125














