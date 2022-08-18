// Найти позицию минимального элемента в неотсортированном массиве
// Произвести обмен этого значения со значением первой неотсортированной позиции
// Повторять пока есть неотсортированные элементы

int[] arr = {1, 5, 4, 5, 9, 4, 23, 7, 5, 1, 2};

// 1 способ:
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


// Метод, упорядывающий массив
void SelectionSort(int[] array)
{
    for (int i = 0; i <array.Length -1; i++)
    {
        int minPosition = i;
        //ищем минимальный элемент
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        //происходит свап
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);