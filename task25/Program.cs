/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
int bs;
int exp;


int myPowFunct( int baseNumber, int exponentNumber){
    int result = 1;

    for (int i = 0; i < exponentNumber; i++)
        {
            result = result * baseNumber;
        }
    return result;
}

Console.Write($"Введите основание (целое число): ");
if ( int.TryParse(Console.ReadLine(), out bs) )
{
    Console.Write($"Введите показатель степени (целое число): ");
    if ( int.TryParse(Console.ReadLine(), out exp) )
    {
        
        Console.WriteLine($"{bs} в степени {exp} = {myPowFunct(bs, exp)}" );
              
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