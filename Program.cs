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

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да