int[] array = {1, 3, 4, 5, 6, 65, 65, 65, 77};

int n = array.Length; //количество элементов массива
int find = 65;

int index = 0;

while (index < n)
{
    if(array[index] == find) //нужен знак ==
    {
        Console.WriteLine(index);
        break; //прервать функцию
    }
    index++;
}

//поиск позиции числа в array 