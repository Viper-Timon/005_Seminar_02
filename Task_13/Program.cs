// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//оставил 2 решения, чтобы было наглядно
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

// Решение черезv метод с циклом
Console.WriteLine("Введите число для поиска 3го символа слева");
int number = int.Parse(Console.ReadLine());
int numberpos = 3; // можно вообще сделать ввод искомого номера числа, для унификации
if (number < (10 ^ (numberpos-1))) Console.WriteLine ("Введите число большего разряда");
else
{
    Console.WriteLine(FindNumLen(number, numberpos));
}
int FindNumLen(int num, int numpos)
{
    if (num < 0) num = num * -1;
    int div = 1;
    int count = 0;
    int rem = 0;
    while (num >= div)
    {
        rem = num / div;
        div = div * 10;
        count++;
    }

    int numfind = (num / (div/(10 ^ numpos)))%10;
    Console.WriteLine($"Счетчик = {count}" + $"делитель {div}" + $"остаток {rem}");
    
    return numfind;
    
}







