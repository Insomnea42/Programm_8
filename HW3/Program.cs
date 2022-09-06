// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

//int[,] arrayC = new int[mA, nB];
void MultiplyAndPrintArray(int[,] array1, int[,] array2)
{
    int m = array1.GetLength(0);
    int n = array2.GetLength(1);
    int[,] array3 = new int[m, n];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int multy = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                multy += array1[i, k] * array2[k, j];
            }
            array3[i, j] = multy;
            Console.Write(array3[i, j] + "; ");
        }
        Console.WriteLine();
    }

}


//Текст кода
int nA = 2;
int mA = 2;

int nB = 2;
int mB = 2;

int[,] arrayA = new int[mA, nA];
int[,] arrayB = new int[mB, nB];

Console.WriteLine("Матрица А:");
FillAndPrintArray(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица В:");
FillAndPrintArray(arrayB);
Console.WriteLine();

Console.WriteLine("Матрица C:");
MultiplyAndPrintArray(arrayA, arrayB);
