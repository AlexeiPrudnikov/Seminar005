const int maxValue = 1000;
const int minValue = 1;
const int lengthArray = 2;
List<int> GetDigits(int number)
{
    List<int> digits = new List<int>();
    int div = number;
    int mod = 0;
    do
    {
        mod = div % 10;
        digits.Add(mod);
        div /= 10;
    } while (div != 0);
    digits.Reverse();
    return digits;
}
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine(); 
}
int[] MultArray (List<int> a, List<int> b)
{
    int index = 0;
    int[] result = new int[a.Count * b.Count];
    foreach (int i in a)
    {
        foreach (int j in b)
        {
            result[index] = i * j;
            index++;
        }
    }
    return result;

}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 2==========");
Console.WriteLine("На вход подаются два числа случайной длины. Найдите произведение каждого разряда первого числа на каждый разряд второго. Ответ запишите в массив.");
int[] numbers = new int[lengthArray];
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(minValue, maxValue + 1); 
}
Console.WriteLine($"Сгенерированы числа");
PrintArray(numbers);
List<int>[] numLists = new List<int>[lengthArray];
for (int i = 0; i < numbers.Length; i++)
{
    numLists[i] = GetDigits(numbers[i]); 
}
Console.WriteLine("Результат перемножения цифр двух чисел:");
PrintArray(MultArray(numLists[0], numLists[1]));


