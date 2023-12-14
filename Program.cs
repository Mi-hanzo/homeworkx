// Задача 1: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


int[,] mih = new int[4, 4];
double[] mih1 = new double[mih.GetLength(0)];

void create()
{
    for (int i = 0; i < mih.GetLength(0); i++)
    {
        for (int j = 0; j < mih.GetLength(1); j++)
        {
            mih[i, j] = new Random().Next(1, 10);
        }
        System.Console.WriteLine();
    }
}

void print()
{
    for (int i = 0; i < mih.GetLength(0); i++)
    {
        for (int j = 0; j < mih.GetLength(1); j++)
        {
            System.Console.Write(mih[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void sum()
{
    for (int i = 0; i < mih.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < mih.GetLength(1); j++)
        {
            sum += mih[i, j];
        }
        mih1[i] = sum / mih.GetLength(1);
    }
    System.Console.WriteLine();
}

void print1()
{
    for (int i = 0; i < mih1.Length; i++)
    {

        System.Console.Write(mih1[i] + " ");

    }
}

create();
print();
sum();
print1();




// Задача 2: Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.




// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.




// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением понимается создание
// нового двумерного массива без строки и столбца.