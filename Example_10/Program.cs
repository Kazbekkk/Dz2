int RandomNum = new Random().Next(100, 1000); // Задаем диапазон от 100 до 999
Console.WriteLine($"Рандомное число от 100 до 1000 будет {RandomNum}");
string num = Convert.ToString(RandomNum); // Конвертируем число из int в string
var TwoNumStr = num[1]; // Берем из строки 2 значение 
int TwoNumInt = TwoNumStr - '0'; // Преобразование var (не явный тип данных) в int 
Console.Write($"Вторая цифра рандомного числа {RandomNum} будет {TwoNumInt}"); // Вывод