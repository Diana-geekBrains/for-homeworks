﻿// // // //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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

double[] CreateRandomArray (int size, double minValue, double maxValue)
 {
        double[] newArray = new double[size];
    
        for(int i = 0; i < size; i++)
        {
            newArray[i] = new Random().NextDouble;    
           
        }
    
        return newArray;
    }
    void ShowArray (double[] array)
    {
      Console.Write("[");
        for(int i = 0; i < array.Length; i++)
        {      
            Console.Write (array[i] + " ");
        }
       Console.Write("]");
       Console.WriteLine ();   
    }

    void Dif(double[] array)

    {
        double Max = array[0];
        double Min = array[0]; 
      for(int i = 0; i < array.Length; i++)   
      {
        if(Max < array[i]) Max= array[i];
        if(Min > array[i]) Min = array[i];
      }
    double res = Max - Min;
          Console.WriteLine($"Разница между максимальным числом {Max} и минимальным {Min} -> {res}");
    }
Console.WriteLine ("Input array size:");
 int size = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine ("Input minimal value of array element:");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine ("Input maximal value of array element:");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  double[] myArry = (CreateRandomArray(size, minValue, maxValue));
  ShowArray(myArry);
  Dif(myArry);

