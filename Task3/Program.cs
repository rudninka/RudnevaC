// Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
void FillArray(int[]array, int A, int B)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}
void PrintArray(int[] array)
{
    for(int i=0; i< array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
int[]array = new int[5];
FillArray(array, 1, 100);
PrintArray(array);
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 3 == 0)
    {
        Console.Write(array[i] );
    }
}
