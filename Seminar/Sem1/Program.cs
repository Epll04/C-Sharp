//System.Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("You number is -> " + num);


//Квадрат числа


//System.Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine($"Quad of {num} -> {num*num}"); //проверка

// на вход принимает два числа и проверяет является ли первое квадратом второго

// а = 25; b = 5  -> yes
// a = 2;  b = 10 -> no
// a = 9;  b = -3 -> yes
// a = -3; b = 9  -> no

// bool a = true, false


// Console.WriteLine("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num2 * num2 == num1)
// {
// Console.WriteLine($"{num1} является квадратом {num2} ");
// }
// else
// {
// Console.WriteLine($"{num1} не является квадратом {num2} ");  
// }

// Задача 3. Напишите программу, которая на вход принимает одно число N, а на выходе показывает все целые числа в промежутке от -N до N

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> "-2, -1, 0, 1, 2"

//
//
//System.Console.Write("Input N: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int count = -n;
//while (count <= n)
//{
//System.Console.Write(count++ +" ");
//}
// Задача 4. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа

// 456 -> 6

// 782 -> 2

// 918 -> 8

// using System.Globalization; // вопрос Андрею: зачем эта строка ?

// System.Console.Write("Input N: "); // вопрос Андрею: зачем здесь слово System ?
// int num = Convert.ToInt32(Console.ReadLine());

// if(num>=100 && num<=999)
// {
// System.Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else
// {
//  System.Console.WriteLine("You input not three-Digit number");  
// }


// int a = 5;

// int b = 7;

// int c;

// c = a+b;

// Console.WriteLine(c);
