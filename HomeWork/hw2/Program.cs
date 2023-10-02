//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//void Reduction ()
//{
//System.Console.WriteLine("Input number: ");
//int x = Convert.ToInt32(Console.ReadLine());
//int num = (x/10);
//int num2 = (num % 10);
//System.Console.WriteLine(num2);
//}
//Reduction();

//-----------------------------------------------------------------------------------------------------------------

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//void Reduction ()
//{
//System.Console.WriteLine("Input number: ");
//int num = Convert.ToInt32(Console.ReadLine());
//    if (num < 100)
//    {
//        Console.WriteLine("третьей цифры нет");
//    }
//    
//    else if (num>=100 && num<1000)
//    {
//        Console.WriteLine($"третья цифра от {num} -> {num % 10}");
//    }
//    
//    else if (num>=1000 && num<10000)
//    
//    {
//       int num1 = (num/10);
//        int num2 = (num1 % 10);
//        Console.WriteLine($"третья цифра от {num} -> {num2}");
//    }
//    
//   else if (num>=10000 && num<100000)
//    {
//        int num1 = (num/100);
//        int num2 = (num1 % 10);
//        Console.WriteLine($"третья цифра от {num} -> {num2}");
//    }
//    
//    else if (num>=100000 && num<1000000)
//   {
//        int num1 = (num/1000);
//        int num2 = (num1 % 10);
//       Console.WriteLine($"третья цифра от {num} -> {num2}");
//    }
//    
//     else if (num>=1000000)
//    {
//        Console.WriteLine($"Слишком большое число :))");
//    }    
//}
//
// Reduction();

//-----------------------------------------------------------------------------------------------------------------


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void Reduction ()
{
System.Console.WriteLine("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
 
 if (num == 1)
    {
         Console.WriteLine("Нет. Понедельник не выходной день");
    }
    
    else if (num==2)
    {
        Console.WriteLine("Нет. Вторник не выходной день");
    }
    
    else if (num==3)
    {
        Console.WriteLine("Нет. Среда не выходной день");
    }
    
    else if (num==4)
    {
        Console.WriteLine("Нет. Четверг не выходной день");
    }

    else if (num==5)
    {
        Console.WriteLine("Нет. Пятница не выходной день");
    }

    else if (num==6)
    {
        Console.WriteLine("Да!!! Суббота выходной день");
    }
    
    else if (num==7)
    {
        Console.WriteLine("Да!!! Воскресенье выходной день");
    }
    
    else if (num<1)
    {
        Console.WriteLine("Неправильный ввод");
    }
     else if (num>7)
    {
        Console.WriteLine("Неправильный ввод");
    }
}
Reduction();

    




