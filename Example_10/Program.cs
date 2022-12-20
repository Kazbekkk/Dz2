int RandomNum = new Random().Next(-1000, 1000); // Задаем диапазон от 100 до 999
Console.WriteLine($"Рандомное число от 100 до 1000 будет {RandomNum}");
if (RandomNum < -10 | RandomNum < 10)
{
    Console.WriteLine($"Число {RandomNum} не имеет 2-й цифры");
}
else
{
    if (RandomNum >= 0)
    {
        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[1]; // Берем из строки 2 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Вторая цифра рандомного числа {RandomNum} будет {TwoNumInt}"); // Вывод
    }

    else
    {
        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[2]; // Берем из строки 2 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Вторая цифра рандомного числа {RandomNum} будет {TwoNumInt * -1}"); // Вывод
    }
}