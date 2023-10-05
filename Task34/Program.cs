// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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

void CalcOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0)
            count += 1;
    }
    Console.WriteLine($"Sum of even numbers is {count}");
}

Console.WriteLine ("Enter min of array val:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter max of array val:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter size of array:");
int size = Convert.ToInt32(Console.ReadLine());
if(min < 100 || min >= 999){
    Console.WriteLine($"Error in min number ({min})");
}

else if(max <= 100 || max > 999 || max < min){
    Console.WriteLine($"Error in max number ({max})");
}

else{
int[] newArray = FillArr(min,max,size);
ShowArray(newArray);
CalcOfEven(newArray);
}
