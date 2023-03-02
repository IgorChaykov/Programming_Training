// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
//Вариант оформления понравился!
Console.Clear();
int Prompt(string mess)
{
    System.Console.WriteLine(mess);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}
System.Console.WriteLine("1 - кол-во четных чисел в массиве");
System.Console.WriteLine("2 - сумма элементов с нечетных позиций");
System.Console.WriteLine("3 - разница между наибольшим и наименьшим элементов массива");
int task = Prompt("Введите номер задачи");

switch (task)
{
    case 1:
        Console.Clear();

        Task_34();
        break;

    case 2:
        Console.Clear();
        Task_36();
        break;

    case 3:
        Console.Clear();
        Task_38();
        break;

    default:
        System.Console.WriteLine("задача не ясна");
        break;
}
void PrintArr(int[] arr)
{
    foreach (var item in arr)
    {
        System.Console.Write($"{item} ");
    }
}

System.Console.WriteLine();


void EvenCount(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Четных чисел в массиве {count}");
}

void Task_34()
{

    int fillArr = Prompt("сколько элементов в массиве?");
    Random ran = new Random();
    int[] arr = new int[fillArr];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(100, 1000);

    }
    PrintArr(arr);
    EvenCount(arr);
}

void OddIndSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)  // Считаю, что для обывателя массив начинается с элемента 1, т.е. 0,2,4 и т.д. - нечетные
    {
        sum = sum + arr[i];
    }
    System.Console.WriteLine($"Сумма нечетных элементов {sum} ");
}

void Task_36()
{

    int fillArr = Prompt("сколько элементов в массиве?");

    Random ran = new Random();
    int[] arr = new int[fillArr];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(0, 100);
    }
    PrintArr(arr);
    OddIndSum(arr);

}

void MinMax(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
            min = arr[i];
        if (max < arr[i])
            max = arr[i];
    }
    
    System.Console.WriteLine();
    System.Console.WriteLine($"Разница между наибольшим и наименьшим числами равна {max-min}");
}

void Task_38()
{

    int fillArr = Prompt("сколько элементов в массиве?");

    Random ran = new Random();
    int[] arr = new int[fillArr];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ran.Next(-99, 100);
    }
    PrintArr(arr);
    MinMax(arr);
}