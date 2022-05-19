// попытка создать массив вводом
Console.Write("Введите кол-во элементов массива -> ");
int len1 = int.Parse(Console.ReadLine());
int [] array = new int [len1];

void FillArray (int[] col1)
{
    int len2 = col1.Length;
    int index = 0;
        while (index < len2)
    {
        Console.Write ($"Введите эл.№ {index} -> ");
        array[index] = int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] col2)
{
    int count = col2.Length;
    int position = 0;
    while (position < count) 
    {
        Console.WriteLine(col2[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);
int ArrayPos (int [] col3, int find)
{
    int count = col3.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        
        if (col3[index] == find) 
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
Console.Write("Введите искомый эл-т -> ");
int findNum = int.Parse(Console.ReadLine());
Console.WriteLine($"Номер скомого эл-та {ArrayPos(array, findNum)}");