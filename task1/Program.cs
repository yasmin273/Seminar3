/// Проверяет является ли входное число палиндром.
/// <param name="num">5-ти значное число.</param>
bool IsPalindrome(int num)
{
    var currNum = num;
    var digits = new List<int>();

    
    while (currNum != 0)
    {
        digits.Add(currNum % 10);
        currNum /= 10;
    }

    var countDigits = digits.Count();

    
    for (int i = 0; i < countDigits / 2; i++)
    {
        
        if (digits[i] != digits[countDigits - i - 1])
            return false;
    }

    return true;
}


Console.Write("Введите 5-ти значное число: ");
var num = int.Parse(Console.ReadLine());

var result = IsPalindrome(num) ? "да" : "нет";
Console.WriteLine($"{num} -> {result}");