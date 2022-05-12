// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] 
// и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine ($"Number = {number}");
int firstDigit = number/10;
int secondDigit = number%10;
Console.WriteLine ($"1st = {firstDigit}");
Console.WriteLine ($"2nd = {secondDigit}");

Console.WriteLine (firstDigit > secondDigit ? $"Max = {firstDigit}" : $"Max = {secondDigit}");
