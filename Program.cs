// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите натуральное число ");
// int x= Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int y= Convert.ToInt32 (Console.ReadLine());
// if(x>y) Console.WriteLine("Второе число больше первого");
// else if(y>x) Console.WriteLine("Первое число меньше второго");

// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите натуральное число ");
// int x= Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int y= Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите натуральное число ");
// int z= Convert.ToInt32 (Console.ReadLine());
// if(x>y)
// if(x>z) Console.WriteLine("Первое число является максимальным");
// if(y>x)
// if(y>z) Console.WriteLine("Второе число является максимальным");
// if(z>y)
// if(z>x) Console.WriteLine("Третье число является максимальным");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите натуральное число ");
// int x=Convert.ToInt32 (Console.ReadLine());
// if (x % 2==1) 
// {
//     Console.WriteLine("Не чётное");
// }
// else 
// {
//     Console.WriteLine("Чётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите натуральное число ");
int x= Convert.ToInt32 (Console.ReadLine());
int count = 1;
while (count<x)
{
    if (count%2==0)
    {
        Console.WriteLine(count+",");
        count++;
    }
    else count++;
}
