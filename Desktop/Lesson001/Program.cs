// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// System.Console.Write("Введите число ");
// string numbers = Console.ReadLine();
// string newNumbers = String.Empty;

// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     newNumbers += numbers[i];
// }

// bool Comparison(string num1, string num2)
// {
//     bool result = num1 == num2;
//     return result;
// }
//  if (Comparison(numbers, newNumbers))
//     {
//         System.Console.WriteLine("Это палиндром");
//     }
//     else
//     {
//         System.Console.WriteLine("Это не палиндром");
//     }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// System.Console.WriteLine("Введите координаты первой точки ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// double y1 = Convert.ToInt32(Console.ReadLine());
// double c1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координаты второй точки ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// double y2 = Convert.ToInt32(Console.ReadLine());
// double c2 = Convert.ToInt32(Console.ReadLine());

// double lengthGet(double a1, double b1, double c1, double a2, double b2, double c2)
// {
//     return Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2) + Math.Pow((c1 - c2), 2));
// }

// Console.Write("Длина отрезка = ");
// Console.Write(lengthGet(x1, y1, c1, x2, y2, c2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



// Console.WriteLine("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[] TableСube(int s)
// {
//     double[] array = new double[s];
//     for (int i = 1; i <= n; i++)
//     {
//         array[i - 1] = Math.Pow((i), 3);
//     }
//     return array;
// }

// double[] result = TableСube(n);

// for (int i = 0; i < result.Length; i++)
// {
//     Console.WriteLine(result[i]);
// }
