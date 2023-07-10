// Задача 62: Заполните 
// спирально массив 4 на 4.
// 1  2  3  4 
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7 

int size = 5;
int[,] array = new int[size, size];
GetSpiral(array, size);
PrintArray(array, size);
//----------------------МЕТОДЫ-------------------------------------
// метод заполнения массива случайными значениями
void GetSpiral(int[,] array, int size)
{
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= size * size)
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)
            j++;
        else if (i < j && i + j >= size - 1)
            j++;
        else if (i >= j && i + j > size - 1)
            j--;
        else
            j--;
        value++;

    }
}
// метод вывода массива на экран
void PrintArray(int[,] array, int size)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write($"0 {array[i, j]} ");
                Console.Write("");
            }
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

