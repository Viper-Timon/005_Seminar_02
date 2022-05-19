
Console.WriteLine("Введите число дня недели от 1 до 7:");
var day = Convert.ToInt32(Console.ReadLine());
string [] Weekend = {"нет", "нет", "нет", "нет", "нет", "да", "да"};
if (day > 0 && day < 8)
{
    Console.WriteLine(Weekend [day - 1]);
}
else Console.WriteLine("Вы ввели некорректное число дня недели");

