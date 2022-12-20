int RandomNum = new Random().Next(-100, 101); // Задаем диапазон от -100 до 100
Console.WriteLine($"Рандомное число от -100 до 100 будет {RandomNum}");
if (RandomNum < 0) // Проверка на отрицательное число 
{
    if (RandomNum > -10)
    {
        Console.WriteLine($"Число {RandomNum} не имеет 2-й цифры");
    }

    else
    {

        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[2]; // Берем из строки 2 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Вторая цифра рандомного числа {RandomNum} будет {TwoNumInt * -1}"); // Вывод

    }
}

else
{
    if (RandomNum < 10)
    {
        Console.WriteLine($"Число {RandomNum} не имеет 2-й цифры");
    }

    else
    {
        string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
        var TwoNumStr = num[1]; // Берем из строки 2 значение 
        int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
        Console.Write($"Вторая цифра рандомного числа {RandomNum} будет {TwoNumInt}"); // Вывод
    }
}