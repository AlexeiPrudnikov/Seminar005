const int maxValue = 9;
const int minValue = 0;
const int lengthArray = 15;
void GenArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
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
bool IsContein(int[]array, int number)
{
    string arrayStr = String.Concat<int>(array);
    string numStr = number.ToString();

    return arrayStr.Contains(numStr);
}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 1==========");
Console.WriteLine("Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет, есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.");
int[] array = new int[lengthArray];
GenArray(array);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine();
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");
Console.Write($"Число {number} ");
if (!IsContein(array,number)) Console.Write("НЕ "); 
Console.WriteLine("содежится в исходном массиве");