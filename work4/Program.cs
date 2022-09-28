// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rowsX = ReadInt("Enter number of rowsX for first matrix: ");
int rowsY = ReadInt("Enter number of rowsY for first matrix: ");
int rowsZ = ReadInt("Enter number of rowsZ for first matrix: ");
int[,,] matrix1 = new int[rowsX, rowsY, rowsZ];

Printarrayay(FillMatrix(matrix1));

int[,,] FillMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int number = new Random().Next(10, 99);
                if (FindElement(array, number))
                {
                    continue;
                }
                array[i, j, k] = number;
                k++;
            }
        }
    }
    return array;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int[,,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == num)
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Printarrayay(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}
