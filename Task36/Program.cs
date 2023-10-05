// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

void CalcOfOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
            sum += array[i];
    }
    Console.WriteLine(sum);
}
Console.WriteLine ("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
int [] newArray = FillArr(min, max, size);
ShowArray(newArray);
CalcOfOddIndex(newArray);