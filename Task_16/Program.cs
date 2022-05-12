// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите 1ое число -> ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2ое число -> ");
int num2 = int.Parse(Console.ReadLine());
if (num1 * num1 == num2) Console.WriteLine("Второе число явялется квадратом первого");
else if (num2 * num2 == num1) Console.WriteLine("Первое число явялется квадратом второго");
else Console.WriteLine("Не являются квадратами друг друга");