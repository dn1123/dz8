int height = EnterInt("введите количество строк в массиве: ");
int width = EnterInt("введите количество столбцов в массиве: ");


int[,] numbers = new int[height, width];
Fill2DArray(numbers);
Print2DArray(numbers);
int[] sum = RowElementsSum(numbers);
Console.WriteLine($"Наименьшая сумма элементов в строке № {MinRowSumIndex(sum) + 1}");

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }

}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3}");
        }
        Console.WriteLine();
    }
}


int[] RowElementsSum(int[,] numbers)
{
    int[] sum = new int[numbers.GetLength(0)];

    for (int i = 0; i < numbers.GetLength(0); i++)
    {

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum[i] += numbers[i, j];
        }
    }
    return sum;
}

int MinRowSumIndex(int[] sum)
{
    int min = sum[0];
    int minIndex = 0;

    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            minIndex = i;
        }
    }
    return minIndex;
}