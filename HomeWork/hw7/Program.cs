// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//       public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
//     {
//         int[] number = { 0, -1 };
//         if (rowPosition >= 0 && rowPosition < matrix.GetLength(0) && columnPosition >= 0 && columnPosition < matrix.GetLength(1))
//         {
//             number[1] = 0;
//             number[0] = matrix[rowPosition, columnPosition];
//         }
//         return number;
//     }
//   public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main!
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 7;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }


//using System;

//public class Answer

void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++) // заполняем строчки
        {
            for (int j = 0; j < matrix.GetLength(1); j++) //заполняем колонны
            {
                System.Console.Write(matrix[i, j] + "\t");
            }
            System.Console.WriteLine();
        }

    }

int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m]; // выделили память под массив
        int value = 0;

        for (int i = 0; i < n; i++) // заполняем строчки
        {
            for (int j = 0; j < m; j++) //заполняем колонны
            {
                matrix[i, j] = value;
                value += k;
            }
        }
        return matrix; 
    }

double [] FindAverageInColumns (int[,] matrix)   // Метод FindAverageInColumns принимает целочисленную матрицу 
                                                // типа int[,] и возвращает одномерный массив типа double
                                                // Этот метод вычисляет среднее значение чисел в каждом столбце матрицы 
                                                // и сохраняет результаты в виде списка
{
double runningSum=0;
double [] columns = new double [matrix.GetLength(1)];
for (int j = 0; j<matrix.GetLength(1);j++)
{
    runningSum = 0;
    for(int i = 0; i<matrix.GetLength(0);i++)
    {
        runningSum=runningSum+matrix[i,j];
    }
    columns[j]=runningSum/matrix.GetLength(0);
}
return columns;
}


void PrintListAvr (double[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
System.Console.WriteLine();
}



System.Console.WriteLine("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input K: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateIncreasingMatrix (n,m,k);
PrintArray(myArray);
double [] MyList  = FindAverageInColumns (myArray);
PrintListAvr (MyList);



 
