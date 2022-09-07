//  первый способ

int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
System.Console.WriteLine();
}
System.Console.WriteLine();

// второй способ

// name.GetLength(0) - возвращает количество строк в матрице
// name.GetLength(1) - возвращает количество столбцов

// int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
System.Console.WriteLine();
}

System.Console.WriteLine("___________________");

// третий способ

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    System.Console.WriteLine();
    }
}
// int[,] matrix = new int[3, 4]; - не забыть
PrintArray(matrix);

System.Console.WriteLine("____Автозаполнение матрицы____");


// автозаполнение матрицы
// Дописал Random т.к. данный аргумент уже использовался выше

void PrintArrayRandom(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

void FillArrayRandom(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); // [1,10)
        }
    }

}

// int[,] matrix = new int[3, 4]; - не забыть
FillArrayRandom(matrix);
PrintArrayRandom(matrix);