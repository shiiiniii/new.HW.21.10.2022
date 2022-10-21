// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Программа, которая проверяет, является ли выбранный Вами день выходным");
Console.WriteLine("Введите номер дня недели: ");
string[]days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
int NumberOfDay = Convert.ToInt32(Console.ReadLine());
while(NumberOfDay < 6)
{
    Console.WriteLine(days[NumberOfDay - 1]);
    Console.WriteLine("Это будний день(");
    break;
}
    while(NumberOfDay >= 6)
    {
    Console.WriteLine(days[NumberOfDay - 1]);
    Console.WriteLine("Это выходной!)");
    break;
    }