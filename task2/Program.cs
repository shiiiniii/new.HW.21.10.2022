// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 99)
{
     while (number > 999)
    {
        int result1 = (number % 100) / 10;
        Console.WriteLine($"Третья цифра числа {number} равна {result1}");
        break;
    }  
    while (number > 99)
    {
        int n = number / 10;
        int result = number - n * 10;
        Console.WriteLine($"Третья цифра числа {number} равна {result}");
        break;
    }
   
}
else
{
    Console.WriteLine("Третьей цифры в вашем числе нет.");
}