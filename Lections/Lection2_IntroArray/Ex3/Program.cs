// Найти элемент массива, равный find. Массив состоит из n элементов

int[] array = { 1, 4, 78, 62, 2, 32, 79, 14};

int n = array.Length;
int find = 62;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
        
    }
    index++;
}