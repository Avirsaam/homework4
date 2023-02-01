/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void fillArrayWithRandomNumbers(int min, int max, int[] resultArray){
    
   
    Random rnd = new Random();
   
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(min, max);
    }

}


const int arraySize = 8;
const int minRandomNumber = 0;
const int maxRandomNumber = 100;

int[] resultArray = new int[arraySize];

fillArrayWithRandomNumbers( minRandomNumber, maxRandomNumber, resultArray);

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