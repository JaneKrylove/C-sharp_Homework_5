// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

    Console.WriteLine();
}


int[] ourArray = CreateRandomArray(10,100, 999);
PrintArray(ourArray);

int FindEvenDigitals(int [] array)
{
    int number = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) number++;
    }
    return number;
}





