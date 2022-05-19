// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// Примеры:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзнчное число");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int num2 = (number % 100)/10;
    Console.WriteLine (num2);
}
else Console.WriteLine("Вы ввели некорректное число");
