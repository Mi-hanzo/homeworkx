// Задача 1: Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


//int[,] mih = new int[4, 4];

// void create()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             mih[i, j] = new Random().Next(1, 10);
//         }
//         System.Console.WriteLine();
//     }
// }
// create();

// Console.WriteLine("Введите индекс строки массива: ");
// int x=int.Parse(Console.ReadLine());
// Console.WriteLine("Введите индекс столбца массива: ");
// int y = int.Parse(Console.ReadLine());

// if(x < 0 || x >= mih.GetLength(0)|| y < 0 || y >= mih.GetLength(1))
// {
//     Console.WriteLine("Данный элемент отсутствует");
// }
// else
// {
//     Console.WriteLine($"Значение данного элемента - {mih[x,y]}");
// } 




// Задача 2: Задайте двумерный массив. Напишите программу, которая
// поменяет местами первую и последнюю строку массива.


// int[,] mih = new int[4, 4];

// void create()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             mih[i, j] = new Random().Next(1, 10);
//         }
//         System.Console.WriteLine();
//     }
// }

// void print()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             System.Console.Write(mih[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void change()
// {
//     int i =0;
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             int temp=mih[i,j];
//             mih[i,j]=mih[mih.GetLength(0)-1,j];
//             mih[mih.GetLength(0) - 1, j]=temp;
//         }
//         System.Console.WriteLine();
//  }

// create();
// print();
// change();
// print();




// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.


// int[,] mih = new int[5, 4];

// void create()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             mih[i, j] = new Random().Next(1, 10);
//         }
//         System.Console.WriteLine();
//     }
// }

// void print()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             System.Console.Write(mih[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void search()
// {
//     int min=999999999;
//     int i1=0;
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         int sum=0;
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             sum = sum + mih[i, j];
//         }
//         if(sum < min)
//         {
//             min=sum;
//             i1=i;
//         }
//     }
//     System.Console.Write($"Наименьшая сумма у строки под индексом {i1}");
// }

// create();
// print();
// search();




// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением понимается создание
// нового двумерного массива без строки и столбца.


// using System.ComponentModel.DataAnnotations;

// int[,] mih = new int[4, 4];
// int[,] mih1 = new int[mih.GetLength(0)-1, mih.GetLength(1)-1];

// void create()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             mih[i, j] = new Random().Next(1, 10);
//         }
//         System.Console.WriteLine();
//     }
// }

// create();

// void print()
// {
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             System.Console.Write(mih[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// print();

// int del()
// {
//     int min = mih[0, 0];
//     int i1=0;
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//           if (mih[i,j]<min)
//              {
//               min=mih[i,j];
//               i1=i;
//              }
//         }
//     }
//     return i1;
// }

// int del1()
// {
//     int min = mih[0, 0];
//     int j1=0;
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             if (mih[i, j] < min)
//             {
//                 min = mih[i, j];
//                 j1 = j;
//             }
//         }
//     }
//     return j1;
// }

// int i1=del();

// int j1=del1();

// void create1()
// {
//     int i2=0;
//     int j2=0;
//     for (int i = 0; i < mih.GetLength(0); i++)
//     {
//         if (i!=i1)
//         {
//         for (int j = 0; j < mih.GetLength(1); j++)
//         {
//             if (j!=j1)
//             {
//                 mih1[i2, j2] = mih[i, j];
//                 j2++;
//             }
//         }
//         i2++;
//         j2=0;
//         }
//         System.Console.WriteLine();
//     }
// }

// create1();

// void print1()
// {
//     for (int i = 0; i < mih1.GetLength(0); i++)
//     {
//         for (int j = 0; j < mih1.GetLength(1); j++)
//         {
//             System.Console.Write(mih1[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// print1();