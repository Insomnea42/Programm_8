// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Раздел методов
void FillAndPrintArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {

                matr[i, j, k] = new Random().Next(12, 100)-2;
                Console.Write(matr[i, j, k] + " (" + i + ", " + j + ", " + k + ");  ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}

//Раздел кода

int nA = new Random().Next(1, 3);
int mA = nA + new Random().Next(1, 4);
int lA = nA + new Random().Next(1, 4);

int[,,] arrayA = new int[mA, nA, lA];

FillAndPrintArray(arrayA);