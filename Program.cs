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
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
int current = 2;


while(current < n )
{
    if(current %2 == 0)
Console.Write(current + " ");
current++;

}
