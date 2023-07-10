// /Задача 58: Задайте две матрицы. 
// Напишите программу, к оторая будет находить произведение двух матриц. 
int[,] arrayA = GetArray(4, 2);
int[,] arrayB = GetArray(2, 4);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
// Находим произведение 2х матриц
// strA - Строки матрицы А 
// columB - Cтолбцы матрицы В

int strA = arrayA.GetLength(0);
int columB = arrayB.GetLength(1);

int[,] multArray = new int[strA, columB];
// Выполнение условия равенства строк матрицы (А) и столбцов матрицы (В)
if (arrayB.GetLength(1) == arrayA.GetLength(0))
{
    for (int i = 0; i < strA; i++)
    {
        for (int j = 0; j < columB; j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                multArray[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
}

PrintArray(multArray);
//----------------------МЕТОДЫ-------------------------------------
// метод заполнения массива случайными значениями
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
    return array;
}
// метод вывода массива на экран
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}