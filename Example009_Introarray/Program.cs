int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int[] array = { 1, 32, 43, 45, 65, 67, 71, 82, 9 };
array[0] = 12; //каким образом обратиться к массиву и заипсать в него значение 
Console.WriteLine(array[0]); // обратиться к массиву и обратиться к указанному индексу в []

int max = Max(array[0],array[1], array[2],
    array[3], array[4], array[5],
    array[6], array[7], array[8]);
Console.WriteLine(max);