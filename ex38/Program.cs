// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[6];
FillArrayRandomNumbers(array);
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(10,100))/10;
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine();
}
Console.WriteLine($"Макс = {max}, мин = {min}");
Console.WriteLine($"Разница = {max - min}");