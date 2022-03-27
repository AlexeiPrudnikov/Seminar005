const int max = 1000000;
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
int SumDigits (List<int> digits)
{
    int sum = 0;
    foreach (int i in digits)
    {
        sum += i;
    }
    return sum;
}
int MultDigits (List<int> digits)
{
    int mult = 1;
    foreach (int i in digits)
    {
        mult *= i;
    }
    return mult;
}
bool IsMult3xSumm(int number)
{
    List<int> digits = GetDigits(number);
    int sum = SumDigits(digits);
    int mult = MultDigits(digits);
    if ((mult / sum == 3) && (mult % sum == 0)) return true;
    else return false;
}
Console.Clear();
Console.WriteLine("==========Дополнительная задача № 3==========");
Console.WriteLine("Найдите все числа от 1 до 1000000, сумма цифр которых в три раза меньше их произведений. Подсчитайте их количество");
int count = 0;
for (int i = 1; i <= max; i++)
{
    if (IsMult3xSumm(i)) count++;
}
Console.WriteLine();
Console.WriteLine($"В диапазоне от 1 до {max} всего {count} чисел, сумма цифр которых в три раза меньше их произведений");
