/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
int numberBase;
int numberExponent;
int result = 1;


Console.Write($"Введите основание (целое число): ");
if ( int.TryParse(Console.ReadLine(), out numberBase) )
{
    Console.Write($"Введите показатель степени (целое число): ");
    if ( int.TryParse(Console.ReadLine(), out numberExponent) )
    {
        for (int i = 0; i < numberExponent; i++)
        {
            result = result * numberBase;
        }
        Console.WriteLine($"{numberBase} в степени {numberExponent} = {result}" );
              
    }
    else
    {
        Console.WriteLine("Ошибка ввода показателя степени");  
    } 
    
}
else
{
    Console.WriteLine("Ошибка ввода основания");
}