void FillArray(int[] collection) //заполнить массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //void метод ничего не возвращает , не используем return
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // делаем такую позицию, чтобы при вводе числа, которого нет в массиве не выводился индекс 0
    

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //создай новый массив, в котором будет 10 символов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 499);
Console.WriteLine(pos);