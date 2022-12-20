int RandomNum = new Random().Next(10, 150); // Задаем диапазон от 10 до 9999
Console.WriteLine($"Рандомное число от 10 до 150 будет {RandomNum}");
if (RandomNum < 100)
{
    Console.WriteLine($"В {RandomNum} нет 3-го числа");
}

else
{
    string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
    var TwoNumStr = num[2]; // Берем из строки 2 значение 
    int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
    Console.Write($"Третья цифра рандомного числа {RandomNum} будет {TwoNumInt}"); // Вывод
}