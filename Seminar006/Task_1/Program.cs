// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,] array = new int[3, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {

        array[i, j] = new Random().Next(-10, 11);
        // array[i,j] = i+j;
        System.Console.Write($"{array[i, j]}\t ");
    }
    System.Console.WriteLine();
}
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//            // System.Console.Write($"{array[i, j]} ");
//         }

//     }

// }
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + array[i, j];

            // System.Console.Write($"{array[i, j]} ");
        }

    }

}
System.Console.WriteLine(sum);
// System.Console.WriteLine();
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     System.Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//         System.Console.Write($"{array[i, j]} ");

// }
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12