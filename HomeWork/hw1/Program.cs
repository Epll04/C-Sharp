// Задача 2:  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//System.Console.WriteLine("Input numberA: ");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Input numberB: ");
//int b = Convert.ToInt32(Console.ReadLine());

// if (a > b)
// System.Console.WriteLine ($"max number is -> {a}");
// else
// System.Console.WriteLine ($"max number is -> {b}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//System.Console.WriteLine("Input first number: ");
//int A = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Input second number: ");
//int B = Convert.ToInt32(Console.ReadLine());
//System.Console.WriteLine("Input third number: ");
//int C = Convert.ToInt32(Console.ReadLine());
//int max = A;
//if (max < B) max = B;
//if (max < C) max = C;
//System.Console.WriteLine ($"max number is -> {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//System.Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num%2 == 0) 
//System.Console.WriteLine ($"число {num} четное");
//else
//System.Console.WriteLine ($"число {num} нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//System.Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 1;
//while (count <= num)
//{
//System.Console.Write(count++ +" ");
//}

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= num)
   {
    for (num%2 == 0)
    {
     System.Console.Write(count" ");
    }
   }