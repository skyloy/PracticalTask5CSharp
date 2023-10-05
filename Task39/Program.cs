// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

int[] FillArr(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} " );
    }
    Console.WriteLine();
}

void MaxToMin(int[] array)
{
int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int k = 0; k < array.Length-1; k++)
        {
            if(array[k] > array[k+1])
            {
                temp = array[k];
                array[k] = array[k+1];
                array[k+1] = temp;
            }
        }
    }
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} " );
    }
    Console.WriteLine();
    int size = array.Length;
    int res = array[size-1] - array[0];
    Console.WriteLine($"Difference between maximum and minimum array value is {res}");
}
Console.WriteLine ("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int [] newArray = FillArr(min, max, size);
ShowArray(newArray);
MaxToMin(newArray);