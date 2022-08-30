// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// double a = double.Parse(Console.ReadLine());

// Console.Write("Введите положительное число B: ");
// double b = double.Parse(Console.ReadLine());

// if (b < 0)
// {
//     Console.Write("Вы ввели неправильное число! Введите положительное число B: ");
//     b = double.Parse(Console.ReadLine());
// }

// double result = Math.Pow(a, b);

// Console.WriteLine($"Ответ {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumSum(int number)
{
    int count = Convert.ToString(number).Length;
    int number2 = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        number2 = number - number % 10;
        result = result + (number - number2);
        number = number / 10;
    }
    return result;
}

int numsum = NumSum(number);
Console.WriteLine($"Сумма цифр в числе = {numsum}");