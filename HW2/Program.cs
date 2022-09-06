// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[] CheckingArray(int[,] matr)
{
    int[] sumArray = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }

        sumArray[i] = sum;
    }

    return sumArray;
}

//Текст кода
int nA = 3;//new Random().Next(1, 4);
int mA = 5;//nA + new Random().Next(2, 5);



int[,] arrayA = new int[mA, nA];
//int[,] arrayB = new int[mB, nB];


FillAndPrintArray(arrayA);
Console.WriteLine();
int[] min = CheckingArray(arrayA);
//Console.WriteLine();

int n = min[0], numb = 0;

for (int i = 1; i < min.Length; i++)
{
    if (min[i] < n)
    {
        n = min[i];
        numb = i;
    }
}
numb++;

Console.WriteLine("номер строки с наименьшей суммой элементов: " + numb + " строка");