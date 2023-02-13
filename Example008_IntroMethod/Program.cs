int Max(int arg1, int arg2, int arg3)  // Таким способом задается функция (метод)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
} 
int a1 = 15;
int b1 = 21;
int c1 = 34;
int a2 = 63;
int b2 = 2;
int c2 = 4;
int a3 = 2;
int b3 = 53;
int c3 = 33;

//int max = a1;
//if (b1 > max) max = b1;   решение этой задачи 
//if (c1 > max) max = c1;   стихийным способом
//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;
//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

//int max1 = Max (a1, b1, c1);    для каждой тройки значений
//int max2 = Max (a2, b2, c2);    вводится промежуточная переменная 
//int max3 = Max (a3, b3, c3);
//int max = Max (max1, max2, max3);

int max = Max (Max (a1, b1, c1), Max (a2, b2, c2), Max (a3, b3, c3));  // без ввода дополнительных переменных

Console.WriteLine (max);

