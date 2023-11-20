// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже

//       if (number > 9999 && number < 100000)
//         {
//             int digit1 = number / 10000;
//             int digit2_1 = number / 1000;
//             int digit2 = digit2_1 % 10;
//             int digit4_1 = number % 100;
//             int digit4 = digit4_1 / 10;
//             int digit5 = number % 10;
            
//             if (digit1 == digit5  && digit2 == digit4)
//                 {
//                 return true;    
//                 }
//             else
//                 {
//                 return false;
//                 }
//         }
//         else 
//             {
//                 System.Console.WriteLine("Число не пятизначное");
//                 return false;
//             }
      
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 645407;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве
// А (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

// double FindDistance(double xa, double ya, double za,double xb, double yb,double zb)
// {
//    return Math.Round(Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb,2)+ Math.Pow(za-zb,2)),2);
// }
// System.Console.Write("input xa coord: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("input ya coord: ");
// double ya = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input za coord: ");
// double za = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input xb coord: ");
// double xb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input yb coord: ");
// double yb = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input zb coord: ");
// double zb = Convert.ToInt32(Console.ReadLine());

// System.Console.Write(FindDistance(xa,ya,za,xb,yb,zb));




using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
    return Math.Round(Math.Sqrt(Math.Pow(x1-y1,2) + Math.Pow(x2-y2,2)+ Math.Pow(x3-y3,2)),2);
    

    
    
    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}


// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125


// void Kvadrats(int N)  // вопрос Андрею: Почему здесь тип данных void ?
// {
//     int index = 1;  // вопрос Андрею: в этой части кода понятно что вычисляется квадрат числа, а зачем нужна вторая часть кода ?
//     while (index <= N)
//     {
//         System.Console.WriteLine(index * index * index);
//         index++;
//     }
// }
// int Vvod(string message)   //вопрос Андрею: Зачем нужна эта часть кода, зачем нужна каждая строчка ?
// {
//     System.Console.Write(message);
//     int number = Convert.ToInt32(System.Console.ReadLine());
//     return number;
// }
// Kvadrats(Vvod("Введите число: "));
