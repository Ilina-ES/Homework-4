public class Homework04
{
    public static void Main(string[] args)
    {
      /*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
      в натуральную степень B.
        3, 5 -> 243 (3⁵)
        2, 4 -> 16  */
    Exponentiation();

    /*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12 */
    SumOfDigits();

    /*Задача 29: Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
    Пользователь вводит число элементов в массиве, минимальное, и максимальное значение. 
    Надо заполнить массив рандоными данными от минимального до максимального значение. 
    И важное уточнениее, делать все в методе который возвращает массив
    5, 1, 20 -> [1, 2, 5, 7, 19]
    3, 1, 33 -> [6, 1, 33] */
    Massif();
    }

static void Exponentiation()
{
    int numberA;
    int numberB;

    Console.WriteLine("Введите число А: ");
    string dataA = Console.ReadLine();

    Console.WriteLine("Введите число В: ");
    string dataB = Console.ReadLine();

    while(true)
        {
            if(int.TryParse(dataA, out numberA)) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка, введите повторно число A: ");
                dataA = Console.ReadLine();
            }
        }
    while(true)
    {
        if(int.TryParse(dataB, out numberB)) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка, введите повторно число В: ");
                dataB = Console.ReadLine();
            }
    }
    //int result = 0;
    double result = Math.Pow(numberA, numberB);
    Console.WriteLine($"Возведение в степень = {result}");
}

static void SumOfDigits()
{
   int number;

    Console.WriteLine("Введите число: ");
    string data = Console.ReadLine();

    while(true)
        {
            if(int.TryParse(data, out number)) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка, введите повторно число: ");
                data = Console.ReadLine();
            }
        } 

    int sum = 0;

    if(number % 10 <= 0) 
    {
        System.Console.WriteLine($"Сумма чисел = {number}");
    }
    
    else
    {
        while(number > 0 && (number % 10 >= 0))
        {
            sum = sum + (number % 10);
            number = number / 10;
        }
    
    System.Console.WriteLine($"Сумма чисел = {sum}");
    }
}

static void Massif()
{
    System.Console.Write("Введите длину массива: ");
    int count = int.Parse(Console.ReadLine());

    System.Console.Write("Введите минимальный элемент: ");
    int minNumber = int.Parse(Console.ReadLine());

    System.Console.Write("Введите максимальный элемент: ");
    int maxNumber = int.Parse(Console.ReadLine());

    int[] array = new int[count];
    int index = 0;

    while(index < count)
    {
        array[index] = new Random().Next(minNumber, maxNumber);
        index++;
    }

    for (int i = 0; i < array.Length - 1; i++) 
    {
        int minPosition = i; 

        for(int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j; 
        }

        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }

    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}
}