// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[6];
int sum = 0;
FillArray(array);
PrintArray(array);
Console.Write(" - Элементы");
Console.WriteLine();
Console.WriteLine($" 0 1 2 3 4 5 - Позиции");
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}

void FillArray(int[] array)
{
    int Length = array.Length;
    int index = 0;
    while(index < Length)
    {
        array[index] = new Random().Next(0,3);
        index++;
    }
}
void PrintArray(int[] array)
{
    int Length = array.Length;
    int index = 0;
    while(index < Length)
    {
        Console.Write($" {array[index]}");
        index++;
    }    
}
Console.WriteLine($"Сумма нечетных = {sum}");
