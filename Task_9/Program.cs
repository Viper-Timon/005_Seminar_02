// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] 
// и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int FindMax (int num)
{
    int num1 = num / 10;
    int num2 = num % 10;
    int max = num1;
    if (num1 < num2) max = num2;
    return max;
}

int number = new Random().Next(10, 100);
Console.WriteLine ($"Number = {number}");
int maxNum = FindMax (number);
Console.WriteLine ($"Max = {maxNum}");

// int firstDigit = number/10;
// int secondDigit = number%10;
// Console.WriteLine ($"1st = {firstDigit}");
// Console.WriteLine ($"2nd = {secondDigit}");
// Console.WriteLine (firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");
