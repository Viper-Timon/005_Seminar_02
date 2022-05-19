// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Решение задачи через строку

// Console.Clear();
// Console.WriteLine("Введите число для поиска 3го символа");
// var txtnum = Convert.ToInt32(Console.ReadLine());
// if (txtnum < 0) txtnum = txtnum * -1;
// string txtnumtemp = Convert.ToString(txtnum);
// int txtnumlen = txtnumtemp.Length;
// if (txtnumlen > 2) 
// {
//     Console.WriteLine(txtnumtemp[2]);
// }
// else Console.WriteLine("Введите число большего разряда");



// Решение через метод с циклом
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
// Console.Write("Номер элемента слева, который хотели найти ");
int numberpos = 3; // int.Parse(Console.ReadLine()); // можно вообще сделать ввод искомого номера числа, для унификации
                 
if (number <= 0) Console.WriteLine("Введите корректное число");
else if (number < Math.Pow(10, numberpos -1)) Console.WriteLine($"{numberpos}й цифры нет");
else
{
    int result = FindByPos(number, numberpos);
    Console.WriteLine($"{numberpos}й цифрой в числе {number} является {result}");
}



int FindByPos(int num, int numpos)
{
    int rem = num;
    int count = 0;
    while (rem > 0)
    {
        rem = rem / 10;
        count++;
       // Console.WriteLine($"Счетчик = {count} " + $"остаток {rem}"); // проверочный вывод по итрерациям
    }

    double num2 = Math.Floor(num / Math.Pow(10, count - numpos));
    int numFind = Convert.ToInt32(num2) % 10;
    return numFind;
}


