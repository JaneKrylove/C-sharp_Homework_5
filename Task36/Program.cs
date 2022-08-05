// Задача 36:
// Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int [10];

    for (int i = 0; i < 10; i++)

        array[i] = new Random().Next(min, max + 1);

        return array;
}

    

void PrintArray(int [] array)
{
    
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} "); 

}

    int SumOddDigitals (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }

    return sum;

  }

    

int [] elements = CreateRandomArray(10, 1, 100);

Console.Write("[");
PrintArray(elements);

Console.Write("]");

Console.WriteLine();


int number = SumOddDigitals(elements);

Console.Write($"Сумма элементов на нечетных позициях: {number}");