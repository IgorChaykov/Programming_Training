// See https://aka.ms/new-console-template for more information
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("1 - заполняем двумерный массив m x n");
Console.WriteLine("2 - принимаем позицию элемента, выводим его значение");
Console.WriteLine("3 - ищим среднее арифметическое в столбце массива");
Console.WriteLine();

int GetNum(string text)
{
    System.Console.WriteLine(text);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}
int task = GetNum("Введите номер задачи: ");

double[,] GetArrayDoub(int a, int b)
{
    double[,] array = new double[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(-9, 10)), 1);
            // array[i, j] = Math.Round(array[i, j], 1);
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    return array;
}

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 10);
        }
    }
    return array;
}

int lines = GetNum("Количество строк m: ");
int columns = GetNum("Количество столбцов n: ");

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void RetNum(int[,] array)
{
    int lin = GetNum("Какая строка Вас интерисует? ");
    int col = GetNum("Какой столбец Вас интересует? ");
    if (lin > array.GetLength(0))
    {
        System.Console.WriteLine("Такой позиции нет");
        return;
    }
    else if (col > array.GetLength(1))
    {
        System.Console.WriteLine("Нет такой позиции");
        return;
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"По этому адресу находится: {array[lin - 1, col - 1]}");
    }

}

void ArithMean(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j];

        }
        System.Console.WriteLine($"Среднее арифметическое столбца {j+1} : {sum / arr.GetLength(0)}");

    }

}

int[,] Massive = GetArray(lines, columns);

switch (task)
{
    case 1:
        GetArrayDoub(lines, columns);

        break;

    case 2:

        PrintArr(Massive);
        RetNum(Massive);

        break;

    case 3:
        //GetArray(lines, columns);
        PrintArr(Massive);
        System.Console.WriteLine();
        ArithMean(Massive);
        break;

    default:
        System.Console.WriteLine("Задача не ясна");
        break;
}


