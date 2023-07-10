// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива. 
Console.Clear();
int m = Prompt("Введите кол-во строк");
int n = Prompt("Введите кол-во столбцов");

//задаём массив случайных чисел
int[,] mass = GetArray(m, n);
//вывод масива на экран
PrintArray(mass);
// сортировка
SortArray(mass);
//вывод отсортированного посторочно масива на экран
Console.WriteLine("");
PrintArray(mass);
//----------------------МЕТОДЫ-------------------------------------
// метод ввода пользователем значений
int Prompt(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
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

// метод сортировки массива
void SortArray(int[,] array)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (mass[i, k] < mass[i, k + 1])
                {
                    int temp = mass[i, k + 1];
                    mass[i, k + 1] = mass[i, k];
                    mass[i, k] = temp;

                }
            }
        }
    }
}