// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


//оставил 2 решения, чтобы было наглядно
// Решение задачи через строку
Console.Clear();
Console.WriteLine("Введите число для поиска 3го символа");
var txtnum = Convert.ToInt32(Console.ReadLine());
if (txtnum < 0) txtnum = txtnum * -1;
string txtnumtemp = Convert.ToString(txtnum);
int txtnumlen = txtnumtemp.Length;
if (txtnumlen > 2) 
{
    Console.WriteLine(txtnumtemp[2]);
}
else Console.WriteLine("Введите число большего разряда");

// Решение черезv метод с циклом
Console.WriteLine("Введите число для поиска 3го символа");
int number = int.Parse(Console.ReadLine());
int numberpos = 3; // можно вообще сделать ввод искомого, для унификации
int FindNumLen(int num, int numpos)
{
    int index = 0;
    int rem = num
    while ();
}





