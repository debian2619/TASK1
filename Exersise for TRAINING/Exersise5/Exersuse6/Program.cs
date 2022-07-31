int[] arr = {1, 2, 3, 4, 5, 6, 1, 1, 7};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();

}
void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length - 1; i++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);





