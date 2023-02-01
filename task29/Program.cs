/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void fillArrayWithRandomNumbers(int size, int min, int max, out int[] resultArray){
    
    resultArray = default;
    
    int[] result = new int[size];

    Random rnd = new Random();
    int [] myArray = new int[size];
    

    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(min, max);
    }

    resultArray = result;
}


const int arraySize = 8;
const int minRandomNumber = 0;
const int maxRandomNumber = 100;

int[] resultArray;

fillArrayWithRandomNumbers(arraySize, minRandomNumber, maxRandomNumber, out resultArray);

Console.Write("[");
for (int i = 0; i < arraySize; i++)
{
    
    Console.Write(resultArray[i]);
    
    if (arraySize - i > 1)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine("]");
    }
}