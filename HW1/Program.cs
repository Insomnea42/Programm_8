// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Раздел вспомогательных методов
void FillAndPrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
            Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();

    }
}

void DoNewArray(int[,] matr)
{
    int temp;
    int a = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    temp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }

    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();

    }
}

//Текст кода
int mA = 5;//new Random().Next(2, 5);
int nA = 5;//m + new Random().Next(0, 4);


int[,] arrayA = new int[mA, nA];
//int[,] arrayB = new int[mB, nB];


FillAndPrintArray(arrayA);
Console.WriteLine();
DoNewArray(arrayA);
PrintArray(arrayA);
