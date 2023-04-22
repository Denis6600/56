//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void GetArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FindMin(int[,] array)
{
    int k = 0;
    int SumRow = 0;
    int MinSumRow = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        k += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow += array[i, j];
        }
        if (SumRow < k)
        {
            k = SumRow;
            MinSumRow = i;
        }
        SumRow = 0;
    }
    Console.Write($"{MinSumRow+1} строка");
}


Console.Clear();
int[,] array = new int[4, 4];
GetArray(array, 0, 3);
PrintArray(array);

Console.WriteLine();

FindMin(array);

