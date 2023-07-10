// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов. 

Console.Clear();

int[,] mass = GetArray();
PrintArray(mass);
Console.WriteLine();
Console.WriteLine($"Cтрокак с минимально суммой имеет индекс = {MinSumNum(mass)}");



//----------------------МЕТОДЫ-------------------------------------
// метод заполнения массива случайными значениями
int[,] GetArray()
{
    int[,] array = new int[7, 20];
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
// метод нахождения индекси строки с мин суммой элементов
int MinSumNum(int[,] array)
{
    int index = 0;
    // подчет суммы 1й строки
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = mass[0, i] + minSum;
    }
    Console.Write($"cумма 1й строки - {minSum} ");
    Console.WriteLine();

    // подчет суммы c 2й по N  строк
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = mass[i, j] + sum;
        }
        Console.WriteLine($"cумма {i + 1}й строки - {sum} ");
        
        // сравниваем суммы и находим минимальную
        if (minSum > sum)
        {
            minSum = sum;
            index = i;
        }
    }
    Console.WriteLine();
    return index + 1;
}