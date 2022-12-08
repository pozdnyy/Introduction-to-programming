/* 1 найти позицию минимального элемента в неотсортированной части массива
2 произвести обмен этого значения со значением первой неотсортированной
позиции
3 повторять пока есть неотсортированные элементы */

int[] arr = {1, 5, 3, 3, 2, 5, 6, 7, 2};

void PrintArray(int[] array)  //вывести данный массив на экран
{
    int count = array.Length;
    
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}
//метод, который будет упорядочивать массив
void SelectionSort(int[] array)
{
    for (int i = 0; i< array.Length; i++)
    {
        int minPosition = i; 
        //ищем минимальный элемент
        for(int j= i + 1; j < array.Length -1; j++)
        {
            if(array[j]< array[minPosition]) 
            {
                minPosition = j;
            } 
        }
        int temp = array[i]; //поменять позицию с минимальной
        array [i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
