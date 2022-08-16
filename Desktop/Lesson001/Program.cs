// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


System.Console.Write("Введите число ");
string numbers = Console.ReadLine();
string newNumbers = String.Empty;

for (int i = numbers.Length - 1; i >= 0; i--)
{
    newNumbers += numbers[i];
}

bool Comparison(string num1, string num2)
{
    bool result = num1 == num2;
    return result;
}

if (numbers.Length % 2 == 0)
{
    System.Console.WriteLine("С таким кол-вом цифр не возможно выявить палиндром");
}
else
{
    if (Comparison(numbers, newNumbers))
    {
        System.Console.WriteLine("Это палиндром");
    }
    else
    {
        System.Console.WriteLine("Это не палиндром");
    }
}
