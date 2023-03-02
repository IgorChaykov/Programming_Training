// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string[,] table = new string[2, 5];//две строки пять столбцов индексы с 0 
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colimns = 0; colimns < 5; colimns++)
//     {
//         System.Console.WriteLine($"{table[rows, columns]}");
//     }
// }

int[,] matrix = new int[3, 4];

// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j< 4; j++)
//     {
//         System.Console.WriteLine($"{matrix[i, j]}");

//     }
//     System.Console.WriteLine();
// }
void PrArr(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");

        }
        System.Console.WriteLine();
    }
}
void  FullArr(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
}
}
PrArr(matrix);
System.Console.WriteLine();
FullArr(matrix);
PrArr(matrix);
