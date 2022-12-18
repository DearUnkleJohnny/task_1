// Задача 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3




// Console.WriteLine("Введите первое число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberB = Convert.ToInt32(Console.ReadLine());
// if (numberA >= numberB)
// {
//     Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {numberA}");
// }
// else
// {
//     Console.WriteLine($"a = {numberA}; b = {numberB} -> max = {numberB}");
// }




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//


// Задача 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22




// Console.WriteLine("Введите первое число");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int numС = Convert.ToInt32(Console.ReadLine());
// int max = numA;
// if (numB > max)
// {
//     max = numB;
// }
// if (numС > max)
// {
//     max = numС;
// }
// Console.WriteLine($"{numA}, {numB}, {numС} -> {max}");




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//


// Задача 3
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// 3 -> нет
// 7 -> нет




// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine($"{num} -> да");
// }
// else
// {
//     Console.WriteLine($"{num} -> нет");
// }



//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//


// Задача 4
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8




Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int remainder = N % 2;
int evenNum = (N - remainder);
int langht = N;
int[] array = new int[langht];



for (int i = 2; i < langht; i = i + 2)
{
    array[i] = i;
    Console.Write($"{N} -> {array[i]}");
}