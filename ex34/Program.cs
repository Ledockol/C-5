// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] array = new int[5];
int count = 0;
FillArray(array);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
         count++;
    }
}
void FillArray(int[] array)
{
    int Length = array.Length;
    int index = 0;
    while(index < Length)
    {
        array[index] = new Random().Next(100,1000);
        index++;
    }
}
void PrintArray(int[] array)
{
    int Length = array.Length;
    int index = 0;
    while(index < Length)
    {
        Console.Write($"{array[index]} ");
        index++;
    }    
}
Console.WriteLine($"Количество четных чисел: {count}");


