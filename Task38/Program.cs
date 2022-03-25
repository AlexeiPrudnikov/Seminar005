const int maxValue = 10;
const int minValue = -10;
const int lengthArray = 10;
void GenArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1) + rand.NextDouble();
    }
}
void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine(); 
}
double GetArrayDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else
        {
            if (array[i] > max) max = array[i];
        }
    }
    return max - min;
}
Console.Clear();
Console.WriteLine("==========Задача № 38==========");
Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");
double[] array = new double[new Random().Next(2, lengthArray + 1)];
GenArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разность между максимальным и минимальным элементами массива -> {GetArrayDiff(array)}");