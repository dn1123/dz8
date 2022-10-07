Console.WriteLine("Первая матрица:");
int[,] matrix1 = new int[2, 2];

Fill2DArray(matrix1);
Print2DArray(matrix1);

Console.WriteLine("Вторая матрица:");
int[,] matrix2 = new int[2, 2];

Fill2DArray(matrix2);
Print2DArray(matrix2);

Console.WriteLine("Произведение двух матриц:");
Print2DArray(MultiplyArray(matrix1, matrix2));

void Fill2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j],2} ");
        }
        Console.WriteLine();
    }
}

static int[,] MultiplyArray(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        throw new Exception("Нельзя умножать такие матрицы");
    }

    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; 

    for (int i = 0; i < matrix3.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}
