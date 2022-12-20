Console.WriteLine("Сегодня Декабрь 2022г. Какое сегодня число?");
int number = Convert.ToInt32(Console.ReadLine());

if    (number == 3 || number == 4 
    || number == 10 || number == 11 
    || number == 17 || number == 18 
    || number == 24 || number == 25 
    || number == 31 )
{
    Console.WriteLine("Этот день Выходной");
}
else
{
    Console.WriteLine("Солнце еще высоко, работай негр");
}