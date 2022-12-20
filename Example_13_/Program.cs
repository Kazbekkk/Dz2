int RandomNum = new Random().Next(-150, 150); // Задаем диапазон от -150 до 150
Console.WriteLine($"Рандомное число от -150 до 150 будет {RandomNum}");
if (RandomNum < 0) // Проверка на отрицательное число
{
    if (RandomNum > -100)
    {
        Console.WriteLine($"В {RandomNum} нет 3-го числа");
    }

    else
    {
        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[3]; // Берем из строки 3 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Третья цифра рандомного числа {RandomNum} будет {TwoNumInt * -1}"); // Вывод
    }
}

else
{
    if (RandomNum < 100)
    {
        Console.WriteLine($"В {RandomNum} нет 3-го числа");
    }

    else
    {
        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[2]; // Берем из строки 3 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Третья цифра рандомного числа {RandomNum} будет {TwoNumInt}"); // Вывод
    }
}