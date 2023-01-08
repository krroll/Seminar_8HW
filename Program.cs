// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите размерность строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());


// Метод заполнения массива
int [,] GetArray()
{
    int [,] result = new int [rows,columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = new Random().Next(10);
        }
    }
    return result;
}

void SortRows(int [,] result)
{
    int temp = 0;
    
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int z = 0; z < result.GetLength(1); z++)
            {
                if (result[i,j]>result[i,z])
                {
                    temp = result[i,j];
                    result[i,j] = result[i,z];
                    result[i,z]=temp;
                }
            }
        }
    }
 
}

void PrintArray (int [,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i,j]+ " ");
        }
         Console.WriteLine();  
    }
  Console.WriteLine();  
}

// ----------------------------
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

void SumRows(int [,] result)
{    
    int [] array = new int [result.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            array[i] = array[i] + result[i,j];
        }
    Console.WriteLine("Сумму "+(i+1)+" строки= "+array[i]);    
    }

    int min = array[0];
    int index = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k]<min)
        {
            min=array[k];
            index = k+1;
        }
    }
 Console.WriteLine("наименьшая сумма элементов у "+ index +" строки");
}

// ---------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] DigArray(int [,] MatrixFirst, int [,] MatrixSecond)
{
    
    int [,] result = new int [rows,columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int r = 0; r < result.GetLength(1); r++)
            {
                result[i,j]=result[i,j] +  MatrixFirst[i,r] * MatrixSecond[r,j];
            }
        }
    }
    return result;
}

// ----------------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] GetArray3d ()
{
    Console.WriteLine("Введите размерность 3-ей плоскости:");
    int third = Convert.ToInt32(Console.ReadLine());
    int [,,] array = new int[rows,columns,third];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i,j,z] = new Random().Next(10,100);
            }
        }
    }
    return array;
}

void PrintArray3d (int [,,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int z = 0; z < result.GetLength(2); z++)
            {
                Console.Write(result[i,j,z]+ "(" +i+","+j+","+z+") ");                
            }
              Console.WriteLine();  
        }
    }
   Console.WriteLine();  
}

// ----------------------------------
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArraySpiral(int [,] array, int rows, int columns)
{
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * columns)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < rows - 1)
            ++j;
        else if (i < j && i + j >= rows - 1)
            ++i;
        else if (i >= j && i + j > rows - 1)
            --j;
        else
            --i;
        ++num;
    }
}

void PrintArray_Add_Zero (int [,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (result[i,j] < 10) 
            Console.Write(string.Join("","0"+result[i,j]+" "));
            else
            Console.Write(result[i,j]+" ");
        }
         Console.WriteLine();  
    }
  Console.WriteLine();  
}

//------------------------------------------

    // не коментировать!
    int [,] matrix = GetArray();
    string [,] matrix_string = new string[rows,columns];
   // PrintArray(matrix);

    // вызов функции Задачи 54
    // SortRows(matrix);

    // вызов функции Задачи 56
    // SumRows(matrix);

    // вызов функций Задачи 58
    // int [,] MatrixA = GetArray();
    // PrintArray(MatrixA);
    // int [,] MatrixB = GetArray();
    // PrintArray(MatrixB);
    // PrintArray(DigArray(MatrixA,MatrixB));
    
    // вызов функций Задачи 60    
    //PrintArray3d(GetArray3d());
    
    // вызов функций Задачи 62
    FillArraySpiral(matrix,rows,columns);
    PrintArray_Add_Zero(matrix);