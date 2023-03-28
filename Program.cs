// // // //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // // Console.WriteLine("Input number 1");
// // // int num1 = Convert.ToInt32(Console.ReadLine());
// // // Console.WriteLine("Input number 2");
// // // int num2 = Convert.ToInt32(Console.ReadLine());
// // // if(num1 > num2)
// // // {
// // //    Console.WriteLine($"The greater number is {num1} and lesser number is {num2} "); 
// // // }
// // // else
// // //  {
// // // Console.WriteLine($"The greater number is {num2} and lesser number is {num1} "); 
// // // }
// // //  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // Console.WriteLine("Input number 1");
// //  int num1 = Convert.ToInt32(Console.ReadLine());
// //  Console.WriteLine("Input number 2");
// //  int num2 = Convert.ToInt32(Console.ReadLine());
// //  Console.WriteLine("Input number 3");
// //  int num3 = Convert.ToInt32(Console.ReadLine());

// //  if(num1 > num2 && num1 > num3)
// //  {
// //     Console.WriteLine($"The greater number is {num1} "); 
// //  }
// // else
// // if(num2 > num3)
// // {
// //     Console.WriteLine($"The greater number is {num2} "); 
// // }
// // else
// //   {
// //  Console.WriteLine($"The greater number is {num3} "); 
// //  }
// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num % 2 == 0)
// {
//     Console.WriteLine("The number is even");
// }
// else
// {
// Console.WriteLine("The number is not even");
// }
// //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Input number");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = 2;

// if(n>1)
// {
// while(current < n )
// {
//     if(current %2 == 0)
// Console.Write(current + " ");
// current++;
// }
// }
// else 
// {
//   Console.WriteLine("The number is not even");  
// }

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// int SecondNumber(int num)
// {
//   int ed = num / 10;
//   int sot = num / 100;
//   return ed - sot * 10;
// }

// int randomnum = new Random().Next(100, 1000);
// int res = SecondNumber(randomnum);
// Console.WriteLine($"The second digit of {randomnum} is {res}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int ThirdNumber(int num)
// {
//    while(num > 999)  
//    {
//     num = num / 10;
//    }
//    return num % 10;
   
//  }

//  int randomnum = new Random().Next(1, 999999);
 
// int res = ThirdNumber(randomnum);
//  Console.WriteLine($"The third digit of {randomnum} is {res}");

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  string dayOff(int num)
//  {
//   if(num <= 5)
//   {
//     return ("There is not day off. Work!!!");
//   }
//   return ("Yes, this is the day off. Enjoy while you can..");
//  } 

//  int randomnum = new Random().Next(1, 8);
//  string res = Convert.ToString(dayOff(randomnum));
// Console.WriteLine(res);

//Задача19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


//  bool Palindrome(int num)
//  {
//  int number = num;
//  int reverse = 0;
//  while(num > 0)
//   {
//  int digit = num % 10;
//  reverse = reverse * 10 + digit;
//  num = num / 10;
//   }
//   if(number == reverse)
//   {
//   return true;
//   }
// return false;
//  }
//  Console.WriteLine("Input number");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Palindrome(num);
//  Console.WriteLine($"Number {num} is palindrome -> {Palindrome(num)}");


//Напишите программу, которая принимает на вход координаты трех точек и находит расстояние между ними в 3D пространстве.

// double FindDistance(double x1, double y1, double x2, double y2, double z1, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
// }

// Console.WriteLine("Input coordinate X of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of A point: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of B point: ");
// double z2 = Convert.ToDouble(Console.ReadLine());


// double distance = FindDistance(x1, y1, z1, x2, y2, z2);
// Console.WriteLine($"Distance between A and B is {distance}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void FindQ(int n)
//  {
//      int i = 0;
//      int res = 0;
//      while (i < n)
//      {
//          i++;
//          res = i*i*i;
//          Console.WriteLine($"{i} -> {res}");
//      }
//  }
//  Console.WriteLine("Input N:");
//  int n = Convert.ToInt32(Console.ReadLine());
//  FindQ(n);

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

//  int NatStep(int numA, int numB )
//  {
//   int i=1;
//   int res=1;
//  for (i=1; i <= numB; i++)
//  {
//      res = res * numA;
     
//  }
//  return res;
//  }
//  Console.WriteLine("Input first number:");
//   int A = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine("Input second number:");
//   int B = Convert.ToInt32(Console.ReadLine());
//   Console.WriteLine($"{A},{B} -> {NatStep (A, B)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

//  int Sum(int n)
//  {
//     int number = n;
//     int res = 0;
//    while (number > 0)
//    {
//     res = res + number % 10;
//     number = number / 10;
//    }
// return res;
//  }
// Console.WriteLine("Input number: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A}-> {Sum(A)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//      int[] newArray = new int[size];
//      for(int i = 0; i < size; i++)
//      {
//          newArray[i] = new Random().Next(minValue, maxValue+1);
//      }
//      return newArray;
//  }

//  void ShowArray (int[] array)
//  {
//     Console.Write ("[");
//      for(int i = 0; i < array.Length; i++)
//      {
        
//          Console.Write (array[i]  + " ");
         
//      }
//      Console.Write ("]");
//      Console.WriteLine ();
//  }

//  Console.WriteLine ("Input array size:");
//  int size = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine ("Input minimal value of array element:");
//  int minValue = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine ("Input maximal value of array element:");
//  int maxValue = Convert.ToInt32(Console.ReadLine());
//  ShowArray(CreateRandomArray(size, minValue, maxValue));

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size, int minValue, int maxValue)
//   {
//       int[] newArray = new int[size];
//       for(int i = 0; i < size; i++)
//       {
//           newArray[i] = new Random().Next(minValue, maxValue+1);
//       }
//       return newArray;
//   }
//   void ShowArray (int[] array)
//   {
//     Console.Write("[");
//       for(int i = 0; i < array.Length; i++)
//       {
        
//           Console.Write (array[i] + " ");
          
//       }
//       Console.Write("]");
//       Console.WriteLine ();
      
//   }
// void Sum (int[] array)
// {
//     int sum = 0;   
    
//     for(int i = 0; i < array.Length; i++)
//     {
//        int ostatok = array[i] % 2;  
//         if(ostatok == 0) sum = sum +1;
        
//     }
//     Console.WriteLine ($"Четных чисел в этом массиве {sum}");

// }
// Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input minimal value of array element:");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Input maximal value of array element:");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArry = (CreateRandomArray(size, minValue, maxValue));
// ShowArray(myArry);
// Sum(myArry);

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//        int[] newArray = new int[size];
//        for(int i = 0; i < size; i++)
//        {
//            newArray[i] = new Random().Next(minValue, maxValue+1);
//        }
//        return newArray;
//    }
//    void ShowArray (int[] array)
//    {
//      Console.Write("[");
//        for(int i = 0; i < array.Length; i++)
//        {      
//            Console.Write (array[i] + " ");
//        }
//       Console.Write("]");
//       Console.WriteLine ();   
//    }
//    void Sum(int[] array)
//    {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {

//      if(i % 2 == 1) sum= sum + array[i];

//     }
// Console.WriteLine($"The sum of elements is {sum}");

//    }
//    Console.WriteLine ("Input array size:");
// int size = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine ("Input minimal value of array element:");
//  int minValue = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine ("Input maximal value of array element:");
//  int maxValue = Convert.ToInt32(Console.ReadLine());
//  int[] myArry = (CreateRandomArray(size, minValue, maxValue));
//  ShowArray(myArry);
//  Sum(myArry);

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateRandomArray (int size)
//  {
//         double[] newArray = new double[size];
    
//         for(int i = 0; i < size; i++)
//         {
//             newArray[i] = Math.Round (new Random().Next(0, 100) + new Random().NextDouble(),4);    
           
//         }
    
//         return newArray;
//     }
//     void ShowArray (double[] array)
//     {
//       Console.Write("[");
//         for(int i = 0; i < array.Length; i++)
//         {      
//             Console.Write (array[i] + " ");
//         }
//        Console.Write("]");
//        Console.WriteLine ();   
//     }

//     void Dif(double[] array)

//     {
//         double Max = array[0];
//         double Min = array[0]; 
//       for(int i = 0; i < array.Length; i++)   
//       {
//         if(Max < array[i]) Max= array[i];
//         if(Min > array[i]) Min = array[i];
//       }
//     double res = Max - Min;
//           Console.WriteLine($"Разница между максимальным числом {Max} и минимальным {Min} -> {res}");
//     }
// Console.WriteLine ("Input array size:");
//  int size = Convert.ToInt32(Console.ReadLine());
  
//   double[] myArry = (CreateRandomArray(size));
//   ShowArray(myArry);
//   Dif(myArry);

// 6 семинар

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

// void Sum(int[] arry)
// {  
//   int sum1 = 0;
//   for(int i = 0; i < arry.Length; i++ )
//   {
//   if (arry[i] > 0) 
  
//   sum1 = sum1 + 1;
//   }
//   Console.WriteLine($"Sum is {sum1}");
// }
// Console.Write ("Input size");
// int elementsCount = Convert.ToInt32(Console.ReadLine()); 
// int[] arry = new int[elementsCount];
// for (int i = 0; i < arry.Length; i++)
// {
//   Console.WriteLine($"Введите элемент массива под индексом {i}");
//   arry[i]= Convert.ToInt32(Console.ReadLine());
//   Sum(arry);
// }

//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Console.WriteLine ("Input b1:");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k1:");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input b2:");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine ("Input k2:");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


  // семинар 7

  //  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

// double[,] Create2DRandomArray (int rows, int columns)
//  {
//      double[,] myArray = new double[rows, columns];
//      for(int i = 0; i< rows; i++)
//      {
//          for(int j=0; j< columns; j++)
//          {
//              myArray[i,j] = Convert.ToDouble(new Random().Next(-1000, 1000)/10.0);
//          }
//      } return myArray;
//  }

//  void Show2DArray (double[,] array)
//  {
//  for(int i = 0; i < array.GetLength(0);i++)
//  {
//  for(int j = 0; j < array.GetLength(1);j++)
//  {
//  Console.Write(array[i,j] + " ");
//  }
//  Console.WriteLine();
//  }
//  Console.WriteLine();
//  }

//  Console.Write("Введите количество строк ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите количество столбцов ");
//  int columns = Convert.ToInt32(Console.ReadLine());
 
// Show2DArray(Create2DRandomArray(columns, rows));

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


//      int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
//  {
//      int[,] myArray = new int[rows, columns];
//      for(int i = 0; i< rows; i++)
//      {
//          for(int j=0; j< columns; j++)
//          {
//              myArray[i,j] = new Random().Next(minValue, maxValue+1);
//          }
//      } return myArray;
//  }

 

//  void Show2DArray (int[,] array)
//  {
//  for(int i = 0; i < array.GetLength(0);i++)
//  {
//  for(int j = 0; j < array.GetLength(1);j++)
//  {
//  Console.Write(array[i,j] + " ");
//  }
//  Console.WriteLine();
//  }
//  Console.WriteLine();
//  }

// void ShowElement (int [,] array, int Xcolumn, int Yrow)
// {
//   if(Xcolumn > array.GetLength(0)-1 || Yrow> array.GetLength(1)-1) Console.WriteLine("Такой позиции нет");
//   for(int i = 0; i < array.GetLength(0);i++)
//   {
//    for(int j = 0; j < array.GetLength(1);j++)
//    {
//      if(i == Yrow  && j == Xcolumn ) Console.WriteLine($"число в позиции {Xcolumn}, {Yrow} ->{array[Xcolumn,Yrow]}");
//      if(i > array.GetLength(0) || j> array.GetLength(1)) Console.WriteLine("Такой позиции нет");
//    }
   
//   } 
// }

// Console.Write("Введите количество строк ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите количество столбцов ");
//  int columns = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите минимальное значение ");
//  int minValue = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите максимальное значение ");
//  int maxValue = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите позицию строки ");
//  int Хrows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите позицию колонки ");
//  int Ycolumns = Convert.ToInt32(Console.ReadLine());


//  int[,] MyArray= Create2DRandomArray(columns, rows, maxValue, minValue);
//  Show2DArray(MyArray);
//  ShowElement(MyArray, Хrows, Ycolumns);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// void average(int [,] array, int columns )
// {
//   for(int j = 0; j< array.GetLength(1); j++)
//    {
//     string result = string.Empty;
//     double sum = 0;
//       for(int i=0; i< array.GetLength(0); i++) 
//       {
//         sum = sum + array[i,j];
//       }
//       sum = Math.Round(sum / columns, 2);
//        Console.Write(sum + "; ");
//    }

// }
// Console.Write("Введите количество строк ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите количество столбцов ");
//  int columns = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите минимальное значение ");
//  int minValue = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите максимальное значение ");
//  int maxValue = Convert.ToInt32(Console.ReadLine());
 
//  int[,] MyArray= Create2DRandomArray(columns, rows, maxValue, minValue);
//  Show2DArray(MyArray);
//  average(MyArray, columns);

// семинар 8

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

// int[,] SortArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int L = j + 1; L < array.GetLength(1); L++)
//             {
//                 if (array[i, j] < array[i, L])
//                 {
//                     int temp = array[i, j];
//                     array[i, j] = array[i, L];
//                     array[i, L] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }
// Console.Write("Введите количество строк ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите количество столбцов ");
//  int columns = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите минимальное значение ");
//  int minValue = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите максимальное значение ");
//  int maxValue = Convert.ToInt32(Console.ReadLine());
 

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);

// myArray = SortArray(myArray);

// Show2DArray(myArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] SumRows(int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("массив не прямоугольный");
//         return null;
//     }
//     else
//     {
//         int[] arraySumRows = new int[array.GetLength(0)];
//         for(int i = 0; i < array.GetLength(0);i++)
//         {
//             for(int j = 0; j < array.GetLength(1);j++)
//             {
//                 arraySumRows[i] = arraySumRows[i] + array[i,j];
//             }
//         }
//         return arraySumRows;
//     }
// }

// void FindRowWithMinSum(int[] array)
// {
//     int minSumRow = array[0];
//     int minRow = 0;
//     for(int i = 0; i < array.Length;i++)
//     {
//         if(array[i] < minSumRow)
//         {
//             minSumRow = array[i];
//             minRow = i;
//         }
//     }
//     Console.WriteLine($"строка с наименьшей суммой элементов в строке: {minRow + 1}");
// }

// Console.Write("введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("ввведите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Show2DArray(myArray);
// int[] arraySumRows = SumRows(myArray);
// FindRowWithMinSum(arraySumRows);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] CreateFirstMatrix (int rows1, int columns1)
// {
//     int[,] firstMatrix = new int[rows1, columns1];
//     for(int i = 0; i < rows1;i++)
//     {
//         for(int j = 0; j < columns1;j++)
//         {
//             firstMatrix[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return firstMatrix;
// }

// int[,] CreateSecondMatrix (int rows2, int columns2)
// {
//     int[,] secondMatrix = new int[rows2, columns2];
//     for(int i = 0; i < rows2;i++)
//     {
//         for(int j = 0; j < columns2;j++)
//         {
//             secondMatrix[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return secondMatrix;
// }

// int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
// {
//     if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
//     {
//         Console.WriteLine("умножение матриц невозможно");
//     }
//     int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
//     for(int i = 0; i < firstMatrix.GetLength(0);i++)
//     {
//         for(int j = 0; j < secondMatrix.GetLength(1);j++)
//         {
//             resultMatrix[i,j] = 0;
//             for(int k = 0; k < firstMatrix.GetLength(1);k++)
//             {
//                 resultMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
//             }
//         }
//     }
//     return resultMatrix;
// }

// void ShowMatrix (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("введите количество строк для первой матрицы: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите количество столбцов для первой матрицы: ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите количество строк для второй матрицы: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите количество столбцов для второй матрицы: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());

// int[,] firstMatrix = CreateFirstMatrix(rows1, columns1);
// Console.WriteLine("Первая матрица: ");
// ShowMatrix(firstMatrix);

// int[,] secondMatrix = CreateSecondMatrix(rows2, columns2);
// Console.WriteLine("вторая матрица: ");
// ShowMatrix(secondMatrix);

// int[,] multiplicationMatrix = MultiplicationMatrix(firstMatrix, secondMatrix);
// Console.WriteLine("результат умножения матриц: ");
// ShowMatrix(multiplicationMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] Create3DRandomArray (int x, int y, int z, int minValue, int maxValue)
// {
//     int[,,] myArray = new int[x, y, z];
//     for(int i = 0; i < x;i++)
//     {
//         for(int j = 0; j < y;j++)
//         {
//             for(int k = 0; k < z;k++)
//             {
//                 myArray[i, j, k] = new Random().Next(minValue, maxValue + 1);
//                 
//             }
//            
//         }
//     }
//     return myArray;
// }

// void Show3DArray (int[,,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             for(int k = 0; k < array.GetLength(2);k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("введите число x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,,] myArray = Create3DRandomArray(x, y, z, minValue, maxValue);

// Show3DArray(myArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] FillArraySpiral(int rowP, int colP, int count, int[,] array)
// {        
//     for (int j = 0; j < colP; j++)
//     {
//         array[0, j] = count;
//         count++;
//     }
//     for (int i = 1; i < rowP; i++)
//     {
//         array[i, colP - 1] = count;
//         count++;
//     }
//     for (int j = colP - 2; j >= 0; j--)
//     {
//         array[rowP - 1, j] = count;
//         count++;
//     }
//     for (int i = rowP - 2; i > 0; i--)
//     {
//         array[i, 0] = count;
//         count++;
//     }         
//     int row = 1;
//     int col = 1;

//     while (count < rowP * colP)
//     {
//         while (array[row, col + 1] == 0)        
//         {
//             array[row, col] = count;
//             count++;
//             col++;
//         }

//         while (array[row + 1, col] == 0)        
//         {
//             array[row, col] = count;
//             count++;
//             row++;
//         }

//         while (array[row, col - 1] == 0)        
//         {
//             array[row, col] = count;
//             count++;
//             col--;
//         }

//         while (array[row - 1, col] == 0)        
//         {
//             array[row, col] = count;
//             count++;
//             row--;
//         }
//     }
//         
//     for (int i = 0; i < rowP; i++)
//     {
//         for (int j = 0; j < colP; j++)
//         {
//             if (array[i, j] == 0)
//             {
//                 array[i, j] = count;
//             }
//         }
//     }
//     return array;
// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) Console.Write($" 0{array[i, j]}");
//             else Console.Write($" {array[i, j]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int rowP = 4;
// int colP = 4;
// int count = 1;

// int[,] array = new int[rowP, colP];

// array = FillArraySpiral(rowP, colP, count, array);

// Show2DArray(array);