// Задача 60: Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. 
// Напишите программу, 
// которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. 

int[,,] array = new int[6, 5, 4];
GetArray(array);
PrintArray(array);

//----------------------МЕТОДЫ-------------------------------------
// метод заполнения массива неповторяющимися двузначными случайными значениями
void GetArray(int[,,] array)
{
    int[] temp = new int[array.Length];
    int num;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

// метод вывода массива на экран
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({j},{k},{i})\t");
            }
            Console.WriteLine();
        }

    }
}