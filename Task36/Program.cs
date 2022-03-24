
const int maxValue = 100;
const int minValue = -100;
const int lengthArray = 10;
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
int GetSumOddPlaceElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.Clear();
Console.WriteLine("==========Задача № 36==========");
Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях");
int[] array = new int[new Random().Next(2, lengthArray + 1)];
GenArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine($"Сумма элементов на нечетных местах -> {GetSumOddPlaceElements(array)}");