// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateRandomArray(int size, int min, int max)
{
    double[] array = new double [10];

    for (int i = 0; i < 10; i++)

        array[i] = new Random().Next(min, max + 1);

        return array;
}

void PrintArray(double [] array)
{
    
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} "); 

    Console.WriteLine();
}


double DifferenceMaxMin(double [] array)
{
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }

    double diff = max - min;

    return diff;

}

double [] elements = CreateRandomArray(10, 100, 1000);
PrintArray(elements);

Console.WriteLine();

double number = DifferenceMaxMin(elements);

Console.Write($"Разница между max и min = {number}");
 

