/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

const int arraySize = 8;
const int minRandomNumber = 0;
const int maxRandomNumber = 100;

Random rnd = new Random();
int [] myArray = new int[arraySize];

Console.Write("[");
for (int i = 0; i < arraySize; i++)
{
    myArray[i] = rnd.Next(minRandomNumber, maxRandomNumber);    
    Console.Write(myArray[i]);
    
    if (arraySize - i > 1)
    {
        Console.Write(", ");
    }
    else
    {
        Console.WriteLine("]");
    }
}