Console.Clear();
Console.WriteLine("Введите номер задачи: 25, 27, или 29");
int z = Convert.ToInt32(Console.ReadLine());



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

if (z == 25)
{
    Console.WriteLine("Введите два числа");
    bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
    bool isParsedB = int.TryParse(Console.ReadLine(), out int b);

    if (!isParsedA || !isParsedB || b <= 0)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    long aToDegreeOfB = MathPow(a, b);
    Console.WriteLine($"{a}^{b} = {aToDegreeOfB}");
}

// метод - возводит первое число в степень равную второму числу
long MathPow(int number, int pow)
{
    long result = number;
    for (int i = 1; i < pow; i++)
    {
        result *= number;
    }
    return result;
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

if (z == 27)
{
    Console.WriteLine("Введите число");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsedNum)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    int sum = SumOfDigits(num);
    Console.WriteLine($"Сумма цифр в числе = {sum}");
}

// метод - находит сумму цифр в числе
int SumOfDigits(int number)
{
    int result;

    // result = 0;
    // while (number > 0)
    // {
    //     int digit = number % 10;
    //     result += digit;
    //     number /= 10;
    // }

    for (result = 0; number > 0; number /= 10)
    {
        int digit = number % 10;
        result += digit;
    }
    return result;
}



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

if (z == 29)
{
    Console.WriteLine("Введите размер массива");
    bool isParsedElement = int.TryParse(Console.ReadLine(), out int sizeArray);

    if (!isParsedElement)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    Console.WriteLine("Введите числа для массива");
    int[] newArray = EnteringArray(sizeArray);

    PrintArray(newArray);
}

// метод - принимает на ввод элементы массива заданного размера
int[] EnteringArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        bool isParsedElement = int.TryParse(Console.ReadLine(), out int element);

        if (!isParsedElement)
        {
            Console.WriteLine("Ошибка! Не правильно введены данные, попробуйте ещё раз");
            i = i - 1;
        }
        else
        {
            array[i] = element;
        }
    }
    return array;
}

// метод - распечатывает массив через запятую в квадратных скобках [1,2,34,5,6,7]
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}