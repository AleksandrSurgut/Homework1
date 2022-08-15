// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите число  ");
// string numbers = Console.ReadLine();

// bool FindTwoSymbol(string num)
// {
//     bool result = num.Length > 1;
//     return result;
// }
// if (FindTwoSymbol(numbers) == true)
// {
//     Console.WriteLine(numbers[1]);
// }
// else {
//     Console.WriteLine("Вы ввели не верное колл-во чисел");
// }

// Console.Write("Введите число  ");
// string numbers = Console.ReadLine();

// bool FindThreeSymbol(string num)
// {
//     bool result = num.Length > 2;
//     return result;
// }
// if (FindThreeSymbol(numbers) == true)
// {
//     Console.WriteLine(numbers[2]);
// }
// else {
//     Console.WriteLine("третьей цифры нет");
// }
Console.WriteLine("Введите число соотвествующее дню недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());

bool CompareDay(int numberDay)
{
    bool result = numberDay < 1 || numberDay > 7;
    return result;
}

switch (numberDay)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
}

bool WeekDay(int numberDay)
{
    bool result = numberDay == 6 || numberDay == 7;
    return result;
}
if (CompareDay(numberDay))
{
    Console.WriteLine("Это не день недели");
}
else
{
    if (WeekDay(numberDay))
    {
        Console.WriteLine("Ура! Выходной");
    }
    else
    {
        Console.WriteLine("Печаль-беда, не выходной");
    }
}