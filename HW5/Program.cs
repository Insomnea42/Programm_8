//  Напишите программу, которая заполнит спирально массив 4 на 4.

//Вспомогательные методы
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] <= 9) Console.Write("0" + matr[i, j] + "; ");
            else Console.Write(matr[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

//Код программы
Console.WriteLine("Введите длину стороы квадратного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int i = 0, j = 0;
int[,] array = new int[m, m];

int iter = 1;

while (iter <= m * m)
{
    array[i, j] = iter;
    iter++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1) j++;
    else if (i < j && i + j >= array.GetLength(0) - 1) i++;
    else if (i >= j && i + j > array.GetLength(1) - 1) j--;
    else i--;
}
PrintArray(array);