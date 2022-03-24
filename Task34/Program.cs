
const int maxValue = 999;
const int minValue = 100;
const int lengthArray = 30;
void GenArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine(); 
}
int GetCountEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if ((array[i] % 2) == 0) count++;
    }
    return count;
}
Console.Clear();
Console.WriteLine("==========Задача № 34==========");
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
int[] array = new int[new Random().Next(2, lengthArray + 1)];
GenArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine($"Количество четных элементов массива {GetCountEvenElements(array)}");